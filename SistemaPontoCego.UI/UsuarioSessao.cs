public static class UsuarioLogado
{
    public static bool IsAutenticado { get; set; } = false;

    // ADICIONE ESTA LINHA ABAIXO:
    public static string Nome { get; set; }

    public static List<string> Carrinho { get; set; } = new List<string>();

    // Suas quantidades...
    public static int QtdMoletom { get; set; } = 1;
    public static int QtdCalca { get; set; } = 1;
    public static int QtdShort { get; set; } = 1;
    public static int QtdCamisa { get; set; } = 1;
}