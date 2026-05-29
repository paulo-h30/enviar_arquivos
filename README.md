# Sistema de Distribuição de Arquivos

Aplicativo de desktop Windows (WinForms) desenvolvido em C# e .NET 10.0, focado no gerenciamento e manutenção de laboratórios de informática. Ele foi projetado para efetuar transferências de arquivos de forma estritamente sequencial, robusta e automatizada para múltiplos hosts de rede em lote.

## 🚀 Principais Recursos

- **Interface Gráfica Moderna**: Layout intuitivo e corporativo com paleta Light Mode, barra de progresso visual geral e logs detalhados colorizados em tempo real com timestamps.
- **Autenticação Sequencial em Lote**: Permite adicionar múltiplas credenciais dinâmicas de rede que são testadas em loop em cada máquina local até obter sucesso na conexão.
- **Cópia Inteligente de Arquivos**: O sistema compara os metadados dos arquivos. A transferência só ocorre se o arquivo de origem for mais recente que o de destino ou se o arquivo for inexistente na máquina remota.
- **Segurança Aprimorada (P/Invoke)**: Utiliza APIs nativas do Windows (`WNetAddConnection2` e `WNetCancelConnection2` da `mpr.dll`) para conectar via compartilhamento administrativo oculto (`\\IP\C$`) sem mapear letras físicas de disco e realizando a desconexão total segura no bloco `finally` para cada host.
- **Execução como Administrador**: O aplicativo possui manifesto integrado (`app.manifest`) que força a elevação de privilégios via UAC do Windows ao ser iniciado, garantindo permissões completas de escrita na rede.

## 🛠️ Tecnologias Utilizadas

- **C# / .NET 10.0-windows**
- **Windows Forms**
- **P/Invoke (DLL `mpr.dll` / MPR API)**
- **System.Net.NetworkInformation (Ping assíncrono)**

## 📁 Estrutura do Projeto

- `Enviar_dev/`: Contém todo o código-fonte C# limpo e sem comentários da aplicação.
- `Enviar_dev.exe`: Executável final autossuficiente (Self-Contained) e empacotado em arquivo único gerado para produção.
- `.gitignore`: Arquivo para evitar o rastreamento indesejado de pastas compiladas e arquivos pesados.

## 💻 Instruções de Compilação

Para compilar e gerar o executável autossuficiente de produção manualmente a partir do código fonte, navegue até a pasta `Enviar_dev/` pelo terminal e execute o seguinte comando:

```bash
dotnet publish -c Release
```

O executável único compilado de cerca de 128 MB contendo o runtime integrado do .NET será gerado no diretório:
`Enviar_dev/bin/Release/net10.0-windows/win-x64/publish/Enviar_dev.exe`
