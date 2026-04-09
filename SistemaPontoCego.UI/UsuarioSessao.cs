using System.Collections.Generic; // Adicione esta linha para habilitar Listas

namespace EstiloUrbano.UI
{
    public static class UsuarioLogado
    {
        // Dados do Usuário
        public static bool IsAutenticado { get; set; }
        public static int Id { get; set; }
        public static string Nome { get; set; }

        // Carrinho como LISTA para aceitar o comando .Add()
        public static List<string> Carrinho { get; set; } = new List<string>();

        // Quantidades
        public static int QtdMoletom { get; set; }
        public static int QtdCalca { get; set; }
        public static int QtdShort { get; set; }
        public static int QtdCamisa { get; set; }
    }
}