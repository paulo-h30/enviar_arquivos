namespace Enviar_dev;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        
        this.panelHeader = new System.Windows.Forms.Panel();
        this.lblSubtitle = new System.Windows.Forms.Label();
        this.lblTitle = new System.Windows.Forms.Label();
        this.lblAuthor = new System.Windows.Forms.LinkLabel();
        this.picLogo = new System.Windows.Forms.PictureBox();
        this.splitContainerMain = new System.Windows.Forms.SplitContainer();
        this.gbOrigemDestino = new System.Windows.Forms.GroupBox();
        this.btnLimparArquivos = new System.Windows.Forms.Button();
        this.btnAdicionarArquivos = new System.Windows.Forms.Button();
        this.listArquivos = new System.Windows.Forms.ListBox();
        this.lblDestino = new System.Windows.Forms.Label();
        this.txtDestino = new System.Windows.Forms.TextBox();
        this.gbCredenciais = new System.Windows.Forms.GroupBox();
        this.lblNovoUsuario = new System.Windows.Forms.Label();
        this.txtNovoUsuario = new System.Windows.Forms.TextBox();
        this.lblNovaSenha = new System.Windows.Forms.Label();
        this.txtNovaSenha = new System.Windows.Forms.TextBox();
        this.btnAdicionarCredencial = new System.Windows.Forms.Button();
        this.flpCredenciais = new System.Windows.Forms.FlowLayoutPanel();
        this.gbMaquinas = new System.Windows.Forms.GroupBox();
        this.btnCarregarMaquinas = new System.Windows.Forms.Button();
        this.txtMaquinas = new System.Windows.Forms.TextBox();
        this.lblDicaMaquinas = new System.Windows.Forms.Label();
        this.panelBottom = new System.Windows.Forms.Panel();
        this.gbLogProgresso = new System.Windows.Forms.GroupBox();
        this.rtbLog = new System.Windows.Forms.RichTextBox();
        this.panelAcoes = new System.Windows.Forms.Panel();
        this.btnIniciar = new System.Windows.Forms.Button();
        this.progressBar = new System.Windows.Forms.ProgressBar();
        this.lblProgressPercent = new System.Windows.Forms.Label();

        this.panelHeader.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
        this.splitContainerMain.Panel1.SuspendLayout();
        this.splitContainerMain.Panel2.SuspendLayout();
        this.splitContainerMain.SuspendLayout();
        this.gbOrigemDestino.SuspendLayout();
        this.gbCredenciais.SuspendLayout();
        this.gbMaquinas.SuspendLayout();
        this.panelBottom.SuspendLayout();
        this.gbLogProgresso.SuspendLayout();
        this.panelAcoes.SuspendLayout();
        this.SuspendLayout();

        this.panelHeader.BackColor = System.Drawing.Color.FromArgb(26, 54, 93);
        this.panelHeader.Controls.Add(this.lblAuthor);
        this.panelHeader.Controls.Add(this.picLogo);
        this.panelHeader.Controls.Add(this.lblSubtitle);
        this.panelHeader.Controls.Add(this.lblTitle);
        this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.panelHeader.Location = new System.Drawing.Point(0, 0);
        this.panelHeader.Name = "panelHeader";
        this.panelHeader.Size = new System.Drawing.Size(984, 85);
        this.panelHeader.TabIndex = 0;

        this.lblAuthor.ActiveLinkColor = System.Drawing.Color.FromArgb(244, 180, 26);
        this.lblAuthor.AutoSize = true;
        this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(203, 213, 224);
        this.lblAuthor.LinkArea = new System.Windows.Forms.LinkArea(7, 9);
        this.lblAuthor.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
        this.lblAuthor.LinkColor = System.Drawing.Color.FromArgb(144, 205, 244);
        this.lblAuthor.Location = new System.Drawing.Point(20, 65);
        this.lblAuthor.Name = "lblAuthor";
        this.lblAuthor.Size = new System.Drawing.Size(95, 13);
        this.lblAuthor.TabIndex = 3;
        this.lblAuthor.TabStop = true;
        this.lblAuthor.Text = "Autor: paulo-h30";
        this.lblAuthor.VisitedLinkColor = System.Drawing.Color.FromArgb(144, 205, 244);
        this.lblAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblAuthor_LinkClicked);

        this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.picLogo.Location = new System.Drawing.Point(780, 8);
        this.picLogo.Name = "picLogo";
        this.picLogo.Size = new System.Drawing.Size(188, 68);
        this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.picLogo.TabIndex = 2;
        this.picLogo.TabStop = false;

        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTitle.ForeColor = System.Drawing.Color.White;
        this.lblTitle.Location = new System.Drawing.Point(16, 12);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(354, 30);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Sistema de distribuição de arquivos";

        this.lblSubtitle.AutoSize = true;
        this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(144, 205, 244);
        this.lblSubtitle.Location = new System.Drawing.Point(20, 44);
        this.lblSubtitle.Name = "lblSubtitle";
        this.lblSubtitle.Size = new System.Drawing.Size(643, 15);
        this.lblSubtitle.TabIndex = 1;
        this.lblSubtitle.Text = "Transferência inteligente de arquivos via rede local com autenticação dupla em compartilhamento administrativo (C$).";

        this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
        this.splitContainerMain.Location = new System.Drawing.Point(0, 85);
        this.splitContainerMain.Name = "splitContainerMain";

        this.splitContainerMain.Panel1.Controls.Add(this.gbOrigemDestino);
        this.splitContainerMain.Panel1.Controls.Add(this.gbCredenciais);
        this.splitContainerMain.Panel1.Padding = new System.Windows.Forms.Padding(12, 12, 6, 6);

        this.splitContainerMain.Panel2.Controls.Add(this.gbMaquinas);
        this.splitContainerMain.Panel2.Padding = new System.Windows.Forms.Padding(6, 12, 12, 6);
        this.splitContainerMain.Size = new System.Drawing.Size(984, 370);
        this.splitContainerMain.SplitterDistance = 500;
        this.splitContainerMain.TabIndex = 1;

        this.gbOrigemDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.gbOrigemDestino.BackColor = System.Drawing.Color.FromArgb(247, 250, 252);
        this.gbOrigemDestino.Controls.Add(this.btnLimparArquivos);
        this.gbOrigemDestino.Controls.Add(this.btnAdicionarArquivos);
        this.gbOrigemDestino.Controls.Add(this.listArquivos);
        this.gbOrigemDestino.Controls.Add(this.lblDestino);
        this.gbOrigemDestino.Controls.Add(this.txtDestino);
        this.gbOrigemDestino.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.gbOrigemDestino.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
        this.gbOrigemDestino.Location = new System.Drawing.Point(12, 12);
        this.gbOrigemDestino.Name = "gbOrigemDestino";
        this.gbOrigemDestino.Size = new System.Drawing.Size(482, 196);
        this.gbOrigemDestino.TabIndex = 0;
        this.gbOrigemDestino.TabStop = false;
        this.gbOrigemDestino.Text = "Origem dos Arquivos && Destino Remoto";

        this.btnAdicionarArquivos.BackColor = System.Drawing.Color.FromArgb(49, 151, 149);
        this.btnAdicionarArquivos.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnAdicionarArquivos.FlatAppearance.BorderSize = 0;
        this.btnAdicionarArquivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnAdicionarArquivos.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnAdicionarArquivos.ForeColor = System.Drawing.Color.White;
        this.btnAdicionarArquivos.Location = new System.Drawing.Point(10, 24);
        this.btnAdicionarArquivos.Name = "btnAdicionarArquivos";
        this.btnAdicionarArquivos.Size = new System.Drawing.Size(145, 26);
        this.btnAdicionarArquivos.TabIndex = 0;
        this.btnAdicionarArquivos.Text = "➕ Adicionar Arquivos";
        this.btnAdicionarArquivos.UseVisualStyleBackColor = false;
        this.btnAdicionarArquivos.Click += new System.EventHandler(this.btnAdicionarArquivos_Click);

        this.btnLimparArquivos.BackColor = System.Drawing.Color.FromArgb(74, 85, 104);
        this.btnLimparArquivos.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnLimparArquivos.FlatAppearance.BorderSize = 0;
        this.btnLimparArquivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLimparArquivos.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnLimparArquivos.ForeColor = System.Drawing.Color.White;
        this.btnLimparArquivos.Location = new System.Drawing.Point(161, 24);
        this.btnLimparArquivos.Name = "btnLimparArquivos";
        this.btnLimparArquivos.Size = new System.Drawing.Size(85, 26);
        this.btnLimparArquivos.TabIndex = 1;
        this.btnLimparArquivos.Text = "🧹 Limpar";
        this.btnLimparArquivos.UseVisualStyleBackColor = false;
        this.btnLimparArquivos.Click += new System.EventHandler(this.btnLimparArquivos_Click);

        this.listArquivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.listArquivos.BackColor = System.Drawing.Color.White;
        this.listArquivos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.listArquivos.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.listArquivos.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
        this.listArquivos.FormattingEnabled = true;
        this.listArquivos.HorizontalScrollbar = true;
        this.listArquivos.ItemHeight = 15;
        this.listArquivos.Location = new System.Drawing.Point(10, 56);
        this.listArquivos.Name = "listArquivos";
        this.listArquivos.Size = new System.Drawing.Size(462, 62);
        this.listArquivos.TabIndex = 2;

        this.lblDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.lblDestino.AutoSize = true;
        this.lblDestino.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblDestino.ForeColor = System.Drawing.Color.FromArgb(74, 85, 104);
        this.lblDestino.Location = new System.Drawing.Point(10, 132);
        this.lblDestino.Name = "lblDestino";
        this.lblDestino.Size = new System.Drawing.Size(325, 15);
        this.lblDestino.TabIndex = 3;
        this.lblDestino.Text = "Caminho Relativo no Destino (ex: C$\\Users\\Public\\Desktop):";

        this.txtDestino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.txtDestino.BackColor = System.Drawing.Color.White;
        this.txtDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtDestino.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtDestino.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
        this.txtDestino.Location = new System.Drawing.Point(10, 153);
        this.txtDestino.Name = "txtDestino";
        this.txtDestino.Size = new System.Drawing.Size(462, 25);
        this.txtDestino.TabIndex = 4;
        this.txtDestino.Text = "C$\\Users\\Public\\Desktop";

        this.gbCredenciais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.gbCredenciais.BackColor = System.Drawing.Color.FromArgb(247, 250, 252);
        this.gbCredenciais.Controls.Add(this.btnAdicionarCredencial);
        this.gbCredenciais.Controls.Add(this.lblNovaSenha);
        this.gbCredenciais.Controls.Add(this.txtNovaSenha);
        this.gbCredenciais.Controls.Add(this.lblNovoUsuario);
        this.gbCredenciais.Controls.Add(this.txtNovoUsuario);
        this.gbCredenciais.Controls.Add(this.flpCredenciais);
        this.gbCredenciais.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.gbCredenciais.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
        this.gbCredenciais.Location = new System.Drawing.Point(12, 214);
        this.gbCredenciais.Name = "gbCredenciais";
        this.gbCredenciais.Size = new System.Drawing.Size(482, 150);
        this.gbCredenciais.TabIndex = 1;
        this.gbCredenciais.TabStop = false;
        this.gbCredenciais.Text = "Credenciais de Rede Autenticáveis (Tentativa em Lote)";

        this.lblNovoUsuario.AutoSize = true;
        this.lblNovoUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblNovoUsuario.ForeColor = System.Drawing.Color.FromArgb(74, 85, 104);
        this.lblNovoUsuario.Location = new System.Drawing.Point(10, 22);
        this.lblNovoUsuario.Name = "lblNovoUsuario";
        this.lblNovoUsuario.Size = new System.Drawing.Size(50, 13);
        this.lblNovoUsuario.TabIndex = 0;
        this.lblNovoUsuario.Text = "Usuário:";

        this.txtNovoUsuario.BackColor = System.Drawing.Color.White;
        this.txtNovoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtNovoUsuario.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtNovoUsuario.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
        this.txtNovoUsuario.Location = new System.Drawing.Point(10, 39);
        this.txtNovoUsuario.Name = "txtNovoUsuario";
        this.txtNovoUsuario.Size = new System.Drawing.Size(150, 23);
        this.txtNovoUsuario.TabIndex = 1;

        this.lblNovaSenha.AutoSize = true;
        this.lblNovaSenha.Font = new System.Drawing.Font("Segoe UI", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblNovaSenha.ForeColor = System.Drawing.Color.FromArgb(74, 85, 104);
        this.lblNovaSenha.Location = new System.Drawing.Point(170, 22);
        this.lblNovaSenha.Name = "lblNovaSenha";
        this.lblNovaSenha.Size = new System.Drawing.Size(42, 13);
        this.lblNovaSenha.TabIndex = 2;
        this.lblNovaSenha.Text = "Senha:";

        this.txtNovaSenha.BackColor = System.Drawing.Color.White;
        this.txtNovaSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtNovaSenha.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtNovaSenha.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
        this.txtNovaSenha.Location = new System.Drawing.Point(170, 39);
        this.txtNovaSenha.Name = "txtNovaSenha";
        this.txtNovaSenha.PasswordChar = '●';
        this.txtNovaSenha.Size = new System.Drawing.Size(150, 23);
        this.txtNovaSenha.TabIndex = 3;

        this.btnAdicionarCredencial.BackColor = System.Drawing.Color.FromArgb(49, 151, 149);
        this.btnAdicionarCredencial.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnAdicionarCredencial.FlatAppearance.BorderSize = 0;
        this.btnAdicionarCredencial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnAdicionarCredencial.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnAdicionarCredencial.ForeColor = System.Drawing.Color.White;
        this.btnAdicionarCredencial.Location = new System.Drawing.Point(330, 38);
        this.btnAdicionarCredencial.Name = "btnAdicionarCredencial";
        this.btnAdicionarCredencial.Size = new System.Drawing.Size(142, 24);
        this.btnAdicionarCredencial.TabIndex = 4;
        this.btnAdicionarCredencial.Text = "➕ Adicionar";
        this.btnAdicionarCredencial.UseVisualStyleBackColor = false;
        this.btnAdicionarCredencial.Click += new System.EventHandler(this.btnAdicionarCredencial_Click);

        this.flpCredenciais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.flpCredenciais.BackColor = System.Drawing.Color.White;
        this.flpCredenciais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.flpCredenciais.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
        this.flpCredenciais.Location = new System.Drawing.Point(10, 68);
        this.flpCredenciais.Name = "flpCredenciais";
        this.flpCredenciais.Padding = new System.Windows.Forms.Padding(4);
        this.flpCredenciais.Size = new System.Drawing.Size(462, 72);
        this.flpCredenciais.TabIndex = 5;
        this.flpCredenciais.AutoScroll = true;
        this.flpCredenciais.WrapContents = true;

        this.gbMaquinas.BackColor = System.Drawing.Color.FromArgb(247, 250, 252);
        this.gbMaquinas.Controls.Add(this.btnCarregarMaquinas);
        this.gbMaquinas.Controls.Add(this.txtMaquinas);
        this.gbMaquinas.Controls.Add(this.lblDicaMaquinas);
        this.gbMaquinas.Dock = System.Windows.Forms.DockStyle.Fill;
        this.gbMaquinas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.gbMaquinas.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
        this.gbMaquinas.Location = new System.Drawing.Point(6, 12);
        this.gbMaquinas.Name = "gbMaquinas";
        this.gbMaquinas.Size = new System.Drawing.Size(468, 352);
        this.gbMaquinas.TabIndex = 0;
        this.gbMaquinas.TabStop = false;
        this.gbMaquinas.Text = "Máquinas Alvo (Um IP ou Nome por linha)";

        this.btnCarregarMaquinas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnCarregarMaquinas.BackColor = System.Drawing.Color.FromArgb(49, 151, 149);
        this.btnCarregarMaquinas.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnCarregarMaquinas.FlatAppearance.BorderSize = 0;
        this.btnCarregarMaquinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnCarregarMaquinas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.3f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnCarregarMaquinas.ForeColor = System.Drawing.Color.White;
        this.btnCarregarMaquinas.Location = new System.Drawing.Point(268, 23);
        this.btnCarregarMaquinas.Name = "btnCarregarMaquinas";
        this.btnCarregarMaquinas.Size = new System.Drawing.Size(190, 26);
        this.btnCarregarMaquinas.TabIndex = 1;
        this.btnCarregarMaquinas.Text = "📂 Carregar de Arquivo .txt";
        this.btnCarregarMaquinas.UseVisualStyleBackColor = false;
        this.btnCarregarMaquinas.Click += new System.EventHandler(this.btnCarregarMaquinas_Click);

        this.txtMaquinas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.txtMaquinas.BackColor = System.Drawing.Color.White;
        this.txtMaquinas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtMaquinas.Font = new System.Drawing.Font("Consolas", 10f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtMaquinas.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
        this.txtMaquinas.Location = new System.Drawing.Point(10, 56);
        this.txtMaquinas.Multiline = true;
        this.txtMaquinas.Name = "txtMaquinas";
        this.txtMaquinas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtMaquinas.Size = new System.Drawing.Size(448, 286);
        this.txtMaquinas.TabIndex = 2;
        this.txtMaquinas.WordWrap = false;

        this.lblDicaMaquinas.AutoSize = true;
        this.lblDicaMaquinas.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
        this.lblDicaMaquinas.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
        this.lblDicaMaquinas.Location = new System.Drawing.Point(10, 29);
        this.lblDicaMaquinas.Name = "lblDicaMaquinas";
        this.lblDicaMaquinas.Size = new System.Drawing.Size(227, 15);
        this.lblDicaMaquinas.TabIndex = 0;
        this.lblDicaMaquinas.Text = "Cole a lista ou carregue de um arquivo txt.";

        this.panelBottom.BackColor = System.Drawing.Color.White;
        this.panelBottom.Controls.Add(this.gbLogProgresso);
        this.panelBottom.Controls.Add(this.panelAcoes);
        this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.panelBottom.Location = new System.Drawing.Point(0, 455);
        this.panelBottom.Name = "panelBottom";
        this.panelBottom.Padding = new System.Windows.Forms.Padding(12, 6, 12, 12);
        this.panelBottom.Size = new System.Drawing.Size(984, 260);
        this.panelBottom.TabIndex = 2;

        this.gbLogProgresso.BackColor = System.Drawing.Color.FromArgb(247, 250, 252);
        this.gbLogProgresso.Controls.Add(this.rtbLog);
        this.gbLogProgresso.Dock = System.Windows.Forms.DockStyle.Fill;
        this.gbLogProgresso.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.gbLogProgresso.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
        this.gbLogProgresso.Location = new System.Drawing.Point(12, 6);
        this.gbLogProgresso.Name = "gbLogProgresso";
        this.gbLogProgresso.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
        this.gbLogProgresso.Size = new System.Drawing.Size(960, 188);
        this.gbLogProgresso.TabIndex = 0;
        this.gbLogProgresso.TabStop = false;
        this.gbLogProgresso.Text = "Console de Execução em Tempo Real (Logs)";

        this.rtbLog.BackColor = System.Drawing.Color.FromArgb(26, 32, 44);
        this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
        this.rtbLog.Font = new System.Drawing.Font("Consolas", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.rtbLog.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        this.rtbLog.Location = new System.Drawing.Point(8, 26);
        this.rtbLog.Name = "rtbLog";
        this.rtbLog.ReadOnly = true;
        this.rtbLog.Size = new System.Drawing.Size(944, 154);
        this.rtbLog.TabIndex = 0;
        this.rtbLog.Text = "";

        this.panelAcoes.BackColor = System.Drawing.Color.White;
        this.panelAcoes.Controls.Add(this.btnIniciar);
        this.panelAcoes.Controls.Add(this.progressBar);
        this.panelAcoes.Controls.Add(this.lblProgressPercent);
        this.panelAcoes.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.panelAcoes.Location = new System.Drawing.Point(12, 194);
        this.panelAcoes.Name = "panelAcoes";
        this.panelAcoes.Size = new System.Drawing.Size(960, 54);
        this.panelAcoes.TabIndex = 1;

        this.btnIniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(49, 151, 149);
        this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnIniciar.FlatAppearance.BorderSize = 0;
        this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnIniciar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnIniciar.ForeColor = System.Drawing.Color.White;
        this.btnIniciar.Location = new System.Drawing.Point(740, 10);
        this.btnIniciar.Name = "btnIniciar";
        this.btnIniciar.Size = new System.Drawing.Size(220, 36);
        this.btnIniciar.TabIndex = 2;
        this.btnIniciar.Text = "⚡ INICIAR TRANSFERÊNCIA";
        this.btnIniciar.UseVisualStyleBackColor = false;
        this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);

        this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.progressBar.ForeColor = System.Drawing.Color.FromArgb(49, 151, 149);
        this.progressBar.Location = new System.Drawing.Point(0, 16);
        this.progressBar.Name = "progressBar";
        this.progressBar.Size = new System.Drawing.Size(660, 24);
        this.progressBar.TabIndex = 0;

        this.lblProgressPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.lblProgressPercent.Font = new System.Drawing.Font("Segoe UI Semibold", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblProgressPercent.ForeColor = System.Drawing.Color.FromArgb(74, 85, 104);
        this.lblProgressPercent.Location = new System.Drawing.Point(666, 16);
        this.lblProgressPercent.Name = "lblProgressPercent";
        this.lblProgressPercent.Size = new System.Drawing.Size(68, 24);
        this.lblProgressPercent.TabIndex = 1;
        this.lblProgressPercent.Text = "0% (0/0)";
        this.lblProgressPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.White;
        this.ClientSize = new System.Drawing.Size(984, 715);
        this.Controls.Add(this.splitContainerMain);
        this.Controls.Add(this.panelBottom);
        this.Controls.Add(this.panelHeader);
        this.DoubleBuffered = true;
        this.MinimumSize = new System.Drawing.Size(900, 600);
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Sistema de distribuição de arquivos";
        this.panelHeader.ResumeLayout(false);
        this.panelHeader.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
        this.splitContainerMain.Panel1.ResumeLayout(false);
        this.splitContainerMain.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
        this.splitContainerMain.ResumeLayout(false);
        this.gbOrigemDestino.ResumeLayout(false);
        this.gbOrigemDestino.PerformLayout();
        this.gbCredenciais.ResumeLayout(false);
        this.gbCredenciais.PerformLayout();
        this.gbMaquinas.ResumeLayout(false);
        this.gbMaquinas.PerformLayout();
        this.panelBottom.ResumeLayout(false);
        this.gbLogProgresso.ResumeLayout(false);
        this.panelAcoes.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel panelHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.LinkLabel lblAuthor;
    private System.Windows.Forms.PictureBox picLogo;
    private System.Windows.Forms.SplitContainer splitContainerMain;
    private System.Windows.Forms.GroupBox gbOrigemDestino;
    private System.Windows.Forms.Button btnAdicionarArquivos;
    private System.Windows.Forms.Button btnLimparArquivos;
    private System.Windows.Forms.ListBox listArquivos;
    private System.Windows.Forms.Label lblDestino;
    private System.Windows.Forms.TextBox txtDestino;
    private System.Windows.Forms.GroupBox gbCredenciais;
    private System.Windows.Forms.Label lblNovoUsuario;
    private System.Windows.Forms.TextBox txtNovoUsuario;
    private System.Windows.Forms.Label lblNovaSenha;
    private System.Windows.Forms.TextBox txtNovaSenha;
    private System.Windows.Forms.Button btnAdicionarCredencial;
    private System.Windows.Forms.FlowLayoutPanel flpCredenciais;
    private System.Windows.Forms.GroupBox gbMaquinas;
    private System.Windows.Forms.Button btnCarregarMaquinas;
    private System.Windows.Forms.TextBox txtMaquinas;
    private System.Windows.Forms.Label lblDicaMaquinas;
    private System.Windows.Forms.Panel panelBottom;
    private System.Windows.Forms.GroupBox gbLogProgresso;
    private System.Windows.Forms.RichTextBox rtbLog;
    private System.Windows.Forms.Panel panelAcoes;
    private System.Windows.Forms.Button btnIniciar;
    private System.Windows.Forms.ProgressBar progressBar;
    private System.Windows.Forms.Label lblProgressPercent;
}
