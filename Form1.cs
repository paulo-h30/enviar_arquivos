using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enviar_dev
{
    public partial class Form1 : Form
    {
        private readonly List<RedeCredencial> _credenciais = new List<RedeCredencial>();

        public Form1()
        {
            InitializeComponent();
            CarregarLogomarca();
            LogInfo("Sistema inicializado com diretivas de proteção. Cadastre as credenciais de rede necessárias.");
        }

        #region Funções de Inicialização e Carregamento

        private void CarregarLogomarca()
        {
            try
            {
                var assembly = System.Reflection.Assembly.GetExecutingAssembly();
                string resourceName = "Enviar_dev.imgs.image_white.png";
                
                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                {
                    if (stream != null)
                    {
                        picLogo.Image = Image.FromStream(stream);
                    }
                    else
                    {
                        LogWarning("Recurso de logomarca embutido não localizado no binário compilado.");
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Falha silenciosa ao carregar recurso da logo: {ex.Message}");
            }
        }

        #endregion

        #region Eventos da Interface Gráfica (UI)

        private void LblAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://github.com/paulo-h30",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível abrir o link do autor: {ex.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdicionarArquivos_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Title = "Selecionar Arquivos para Envio";
                openFileDialog.Filter = "Todos os Arquivos (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in openFileDialog.FileNames)
                    {
                        if (!listArquivos.Items.Contains(file))
                        {
                            listArquivos.Items.Add(file);
                        }
                    }
                    LogInfo($"{openFileDialog.FileNames.Length} arquivo(s) adicionado(s) à fila.");
                }
            }
        }

        private void btnLimparArquivos_Click(object sender, EventArgs e)
        {
            if (listArquivos.Items.Count > 0)
            {
                listArquivos.Items.Clear();
                LogInfo("Lista de arquivos de origem limpa com sucesso.");
            }
        }

        private void btnCarregarMaquinas_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de Texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
                openFileDialog.Title = "Carregar Lista de Máquinas";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string content = File.ReadAllText(openFileDialog.FileName);
                        string[] maquinas = content.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries)
                                                   .Select(m => m.Trim())
                                                   .Where(m => !string.IsNullOrEmpty(m))
                                                   .ToArray();

                        if (maquinas.Length > 0)
                        {
                            txtMaquinas.Text = string.Join(Environment.NewLine, maquinas);
                            LogSuccess($"Importadas {maquinas.Length} máquinas com sucesso do arquivo '{Path.GetFileName(openFileDialog.FileName)}'.");
                        }
                        else
                        {
                            LogWarning("O arquivo selecionado está vazio ou não contém nomes de máquinas/IPs válidos.");
                            MessageBox.Show("O arquivo selecionado não contém máquinas válidas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        LogError($"Erro ao ler o arquivo de máquinas: {ex.Message}");
                        MessageBox.Show($"Ocorreu um erro ao carregar o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAdicionarCredencial_Click(object sender, EventArgs e)
        {
            string usuario = txtNovoUsuario.Text.Trim();
            string senha = txtNovaSenha.Text;

            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("Por favor, insira o nome de usuário da credencial.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AdicionarCredencialNaLista(usuario, senha);

            txtNovoUsuario.Clear();
            txtNovaSenha.Clear();
            txtNovoUsuario.Focus();
        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            if (listArquivos.Items.Count == 0)
            {
                MessageBox.Show("Por favor, selecione pelo menos um arquivo para transferência.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDestino.Text))
            {
                MessageBox.Show(@"Defina um caminho relativo de destino válido (ex: C$\Users\Public\Desktop).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMaquinas.Text))
            {
                MessageBox.Show("Insira pelo menos um IP ou nome de máquina para processar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_credenciais.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos uma credencial de rede ativa para tentar a autenticação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] maquinas = txtMaquinas.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries)
                                              .Select(m => m.Trim())
                                              .Where(m => !string.IsNullOrEmpty(m))
                                              .ToArray();

            if (maquinas.Length == 0)
            {
                MessageBox.Show("Nenhuma máquina válida foi identificada no painel de destino.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetUiState(false);

            progressBar.Minimum = 0;
            progressBar.Maximum = maquinas.Length;
            progressBar.Value = 0;
            UpdateProgressLabel(0, maquinas.Length);

            rtbLog.Clear();
            LogInfo("=== INICIANDO LOTE DE TRANSFERÊNCIA SEQUENCIAL ===");
            LogInfo($"Total de máquinas: {maquinas.Length}");
            LogInfo($"Total de arquivos por máquina: {listArquivos.Items.Count}");
            LogInfo($"Total de credenciais registradas: {_credenciais.Count}");
            LogInfo("--------------------------------------------------------------------------------");

            string destinoRaw = txtDestino.Text.Trim();
            
            List<RedeCredencial> credenciaisLocais = _credenciais.ToList();
            List<string> arquivosOrigem = listArquivos.Items.Cast<string>().ToList();

            await Task.Run(async () =>
            {
                for (int i = 0; i < maquinas.Length; i++)
                {
                    string maquina = maquinas[i];
                    int numeroMaquina = i + 1;

                    LogInfo($"[{numeroMaquina}/{maquinas.Length}] Iniciando processamento da máquina: {maquina}");

                    try
                    {
                        LogInfo($"[{maquina}] Realizando teste de ping rápido...");
                        bool isOnline = await TestarPingAsync(maquina);

                        if (!isOnline)
                        {
                            LogError($"[{maquina}] STATUS: OFFLINE ou Inalcançável. Pulando para a próxima máquina.");
                            IncrementProgress(numeroMaquina, maquinas.Length);
                            LogInfo("--------------------------------------------------------------------------------");
                            continue;
                        }

                        LogSuccess($"[{maquina}] STATUS: ONLINE. Iniciando laço de autenticação de rede...");

                        string shareName = "C$";
                        string subPasta = "";
                        
                        int slashIndex = destinoRaw.IndexOf('\\');
                        if (slashIndex == -1) slashIndex = destinoRaw.IndexOf('/');

                        if (slashIndex != -1)
                        {
                            shareName = destinoRaw.Substring(0, slashIndex);
                            subPasta = destinoRaw.Substring(slashIndex + 1);
                        }
                        else
                        {
                            shareName = destinoRaw;
                        }

                        string remoteShare = $"\\\\{maquina}\\{shareName}";
                        
                        string remoteDestDir = string.IsNullOrEmpty(subPasta) 
                            ? remoteShare 
                            : Path.Combine(remoteShare, subPasta);

                        bool autenticado = false;
                        string usuarioLogado = "";

                        foreach (var cred in credenciaisLocais)
                        {
                            LogInfo($"[{maquina}] Tentando conectar a '{remoteShare}' com usuário '{cred.Usuario}'...");
                            int erroConexao = NetworkShare.Connect(remoteShare, cred.Usuario, cred.Senha);

                            if (erroConexao == 0)
                            {
                                autenticado = true;
                                usuarioLogado = cred.Usuario;
                                LogSuccess($"[{maquina}] Autenticado com SUCESSO via usuário '{cred.Usuario}'!");
                                break;
                            }
                            else
                            {
                                LogWarning($"[{maquina}] Falha com usuário '{cred.Usuario}': {NetworkShare.GetErrorMessage(erroConexao)}");
                            }
                        }

                        if (!autenticado)
                        {
                            LogError($"[{maquina}] STATUS: FALHA DE AUTENTICAÇÃO. Nenhuma credencial cadastrada funcionou. Pulando.");
                            IncrementProgress(numeroMaquina, maquinas.Length);
                            LogInfo("--------------------------------------------------------------------------------");
                            continue;
                        }

                        try
                        {
                            if (!Directory.Exists(remoteDestDir))
                            {
                                LogInfo($"[{maquina}] Criando diretório remoto de destino: '{remoteDestDir}'");
                                Directory.CreateDirectory(remoteDestDir);
                            }

                            int copiados = 0;
                            int ignorados = 0;

                            foreach (string arquivoOrigem in arquivosOrigem)
                            {
                                string nomeArquivo = Path.GetFileName(arquivoOrigem);
                                string arquivoDestinoCompleto = Path.Combine(remoteDestDir, nomeArquivo);

                                bool realizarCopia = false;

                                if (!File.Exists(arquivoDestinoCompleto))
                                {
                                    realizarCopia = true;
                                    LogInfo($"[{maquina}] Arquivo '{nomeArquivo}' inexistente no destino. Copiando...");
                                }
                                else
                                {
                                    DateTime dataOrigem = File.GetLastWriteTime(arquivoOrigem);
                                    DateTime dataDestino = File.GetLastWriteTime(arquivoDestinoCompleto);

                                    if (dataOrigem > dataDestino)
                                    {
                                        realizarCopia = true;
                                        LogInfo($"[{maquina}] Arquivo '{nomeArquivo}' desatualizado no destino (Origem: {dataOrigem:dd/MM/yyyy HH:mm:ss} > Destino: {dataDestino:dd/MM/yyyy HH:mm:ss}). Sobrescrevendo...");
                                    }
                                    else
                                    {
                                        ignorados++;
                                        LogInfo($"[{maquina}] Arquivo '{nomeArquivo}' já está atualizado no destino. Cópia ignorada.");
                                    }
                                }

                                if (realizarCopia)
                                {
                                    File.Copy(arquivoOrigem, arquivoDestinoCompleto, overwrite: true);
                                    copiados++;
                                    LogSuccess($"[{maquina}] Arquivo '{nomeArquivo}' copiado com sucesso!");
                                }
                            }

                            LogSuccess($"[{maquina}] CONCLUÍDO: {copiados} arquivo(s) copiado(s), {ignorados} arquivo(s) já atualizados.");
                        }
                        catch (Exception ex)
                        {
                            LogError($"[{maquina}] Erro de I/O durante a cópia dos arquivos: {ex.Message}");
                        }
                        finally
                        {
                            LogInfo($"[{maquina}] Desconectando sessão com o compartilhamento '{remoteShare}'...");
                            int erroDesconexao = NetworkShare.Disconnect(remoteShare);
                            
                            if (erroDesconexao == 0)
                            {
                                LogInfo($"[{maquina}] Sessão desconectada de forma segura.");
                            }
                            else
                            {
                                LogWarning($"[{maquina}] Falha leve ao desconectar: {NetworkShare.GetErrorMessage(erroDesconexao)}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        LogError($"[{maquina}] Ocorreu um erro inesperado no processamento da máquina: {ex.Message}");
                    }

                    IncrementProgress(numeroMaquina, maquinas.Length);
                    LogInfo("--------------------------------------------------------------------------------");
                }
            });

            LogSuccess("=== PROCESSO DE TRANSFERÊNCIA DE LOTE FINALIZADO ===");
            
            SetUiState(true);
        }

        #endregion

        #region Funções Auxiliares de Gerenciamento de Credenciais

        private void AdicionarCredencialNaLista(string usuario, string senha)
        {
            if (string.IsNullOrWhiteSpace(usuario)) return;

            if (_credenciais.Any(c => c.Usuario.Equals(usuario, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show($"O usuário '{usuario}' já está cadastrado na lista de tentativas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var credencial = new RedeCredencial(usuario, senha);
            _credenciais.Add(credencial);

            Panel cardPanel = new Panel
            {
                BackColor = Color.FromArgb(226, 232, 240),
                Height = 26,
                Margin = new Padding(3, 4, 3, 4),
                BorderStyle = BorderStyle.None
            };

            Label lblUser = new Label
            {
                Text = "👤 " + usuario,
                Font = new Font("Segoe UI", 9f, FontStyle.Regular),
                ForeColor = Color.FromArgb(45, 55, 72),
                AutoSize = true,
                Location = new Point(5, 5)
            };

            Button btnExcluir = new Button
            {
                Text = "✕",
                Font = new Font("Segoe UI Semibold", 8f, FontStyle.Bold),
                ForeColor = Color.FromArgb(229, 62, 62),
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                Width = 20,
                Height = 20,
                Cursor = Cursors.Hand
            };
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 215, 215);
            btnExcluir.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 230, 230);

            Size textSize = TextRenderer.MeasureText(lblUser.Text, lblUser.Font);
            cardPanel.Width = textSize.Width + 35;

            lblUser.Bounds = new Rectangle(5, 4, textSize.Width, 18);
            btnExcluir.Bounds = new Rectangle(cardPanel.Width - 22, 3, 18, 18);

            btnExcluir.Click += (sender, e) =>
            {
                flpCredenciais.Controls.Remove(cardPanel);
                _credenciais.Remove(credencial);
                LogInfo($"Credencial do usuário '{usuario}' foi removida.");
            };

            cardPanel.Controls.Add(lblUser);
            cardPanel.Controls.Add(btnExcluir);

            flpCredenciais.Controls.Add(cardPanel);
            
            LogInfo($"Credencial do usuário '{usuario}' registrada na fila.");
        }

        #endregion

        #region Funções Auxiliares de Rede e Validação

        private async Task<bool> TestarPingAsync(string host)
        {
            using (Ping pingSender = new Ping())
            {
                try
                {
                    PingReply reply = await pingSender.SendPingAsync(host, 1200);
                    return reply.Status == IPStatus.Success;
                }
                catch
                {
                    return false;
                }
            }
        }

        #endregion

        #region Utilitários de Interface e Atualização (Threads-Safe)

        private void SetUiState(bool enabled)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() => SetUiState(enabled)));
                return;
            }

            btnIniciar.Enabled = enabled;
            btnAdicionarArquivos.Enabled = enabled;
            btnLimparArquivos.Enabled = enabled;
            btnCarregarMaquinas.Enabled = enabled;
            txtDestino.ReadOnly = !enabled;
            txtMaquinas.ReadOnly = !enabled;

            txtNovoUsuario.ReadOnly = !enabled;
            txtNovaSenha.ReadOnly = !enabled;
            btnAdicionarCredencial.Enabled = enabled;
            flpCredenciais.Enabled = enabled;

            btnIniciar.Text = enabled ? "⚡ INICIAR TRANSFERÊNCIA" : "⏳ EM EXECUÇÃO...";
            btnIniciar.BackColor = enabled ? Color.FromArgb(49, 151, 149) : Color.FromArgb(160, 174, 192);
        }

        private void IncrementProgress(int valorAtual, int total)
        {
            if (progressBar.InvokeRequired)
            {
                progressBar.BeginInvoke(new Action(() => IncrementProgress(valorAtual, total)));
                return;
            }

            progressBar.Value = valorAtual;
            UpdateProgressLabel(valorAtual, total);
        }

        private void UpdateProgressLabel(int valorAtual, int total)
        {
            if (lblProgressPercent.InvokeRequired)
            {
                lblProgressPercent.BeginInvoke(new Action(() => UpdateProgressLabel(valorAtual, total)));
                return;
            }

            double percent = total > 0 ? ((double)valorAtual / total) * 100 : 0;
            lblProgressPercent.Text = $"{percent:F0}% ({valorAtual}/{total})";
        }

        private void AppendLog(string message, Color color)
        {
            if (rtbLog.InvokeRequired)
            {
                rtbLog.BeginInvoke(new Action(() => AppendLog(message, color)));
                return;
            }

            string timestamp = DateTime.Now.ToString("HH:mm:ss");
            
            rtbLog.SelectionStart = rtbLog.TextLength;
            rtbLog.SelectionLength = 0;
            
            rtbLog.SelectionColor = Color.FromArgb(113, 128, 150);
            rtbLog.AppendText($"[{timestamp}] ");

            rtbLog.SelectionColor = color;
            rtbLog.AppendText(message + Environment.NewLine);

            rtbLog.SelectionColor = rtbLog.ForeColor;
            
            rtbLog.SelectionStart = rtbLog.TextLength;
            rtbLog.ScrollToCaret();
        }

        private void LogInfo(string msg) => AppendLog(msg, Color.FromArgb(226, 232, 240));
        private void LogSuccess(string msg) => AppendLog(msg, Color.FromArgb(72, 187, 120));
        private void LogWarning(string msg) => AppendLog(msg, Color.FromArgb(236, 201, 75));
        private void LogError(string msg) => AppendLog(msg, Color.FromArgb(245, 101, 101));

        #endregion
    }

    public class RedeCredencial
    {
        public string Usuario { get; }
        public string Senha { get; }

        public RedeCredencial(string usuario, string senha)
        {
            Usuario = usuario;
            Senha = senha;
        }
    }
}
