using System;
using System.Runtime.InteropServices;

namespace Enviar_dev
{
    public static class NetworkShare
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct NETRESOURCE
        {
            public uint dwScope;
            public uint dwType;
            public uint dwDisplayType;
            public uint dwUsage;
            public string? lpLocalName;
            public string? lpRemoteName;
            public string? lpComment;
            public string? lpProvider;
        }

        private const uint RESOURCETYPE_DISK = 0x00000001;

        [DllImport("mpr.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int WNetAddConnection2(
            ref NETRESOURCE lpNetResource,
            string lpPassword,
            string lpUsername,
            uint dwFlags
        );

        [DllImport("mpr.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int WNetCancelConnection2(
            string lpName,
            uint dwFlags,
            bool fForce
        );

        public static int Connect(string remotePath, string username, string password)
        {
            var netResource = new NETRESOURCE
            {
                dwScope = 0,
                dwType = RESOURCETYPE_DISK,
                dwDisplayType = 0,
                dwUsage = 0,
                lpLocalName = null,
                lpRemoteName = remotePath,
                lpComment = null,
                lpProvider = null
            };

            return WNetAddConnection2(ref netResource, password, username, 0);
        }

        public static int Disconnect(string remotePath)
        {
            return WNetCancelConnection2(remotePath, 0, true);
        }

        public static string GetErrorMessage(int errorCode)
        {
            return errorCode switch
            {
                5 => "Acesso Negado (Credenciais inválidas ou privilégio insuficiente)",
                53 => "Caminho de rede não encontrado (Máquina offline ou DNS/WINS inalcançável)",
                67 => "Nome de rede não encontrado (Compartilhamento C$ desativado ou oculto)",
                85 => "A conexão local já existe (Já autenticado no recurso. Reconexão automática ativa)",
                1219 => "Conflito de credenciais: Uma sessão ativa com outro usuário já existe para este servidor.",
                1326 => "Falha de logon: Nome de usuário desconhecido ou senha incorreta",
                _ => $"Erro do Windows (Código: {errorCode})"
            };
        }
    }
}
