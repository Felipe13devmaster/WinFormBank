namespace WinFormBank.Model
{
    public class Usuario
    {
        public string IdNome { get; set; }
        public string Senha { get; set; }
        public int IdCliente { get; set; }

        public bool ValidaUsuario(Usuario usuario)
        {
            if ((usuario.IdNome == "") || (usuario.Senha == ""))
            {
                return false;
            }
            return true;
        }
    }
}
