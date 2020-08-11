namespace WinFormBank.Model
{
    class Usuario
    {
        public string IdNome { get; set; }
        public string Senha { get; set; }
        public int IdCliente { get; set; }

        public Usuario() { }

        public bool ValidaUsuario(Usuario usuario)
        {
            bool validado = true;

            if ((usuario.IdNome == "") || (usuario.Senha == ""))
            {
                validado = false;
            }
            return validado;
        }
    }
}
