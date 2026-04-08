using System;

namespace EstiloUrbano.UI
{
    public static class UsuarioSessao
    {
        // Se for 'false', o usuário cai no Cadastro. Se for 'true', vai pro Carrinho.
        public static bool EstaLogado = false;

        // Aqui você pode guardar o nome ou e-mail de quem logou
        public static string EmailUsuario = "";
    }
}