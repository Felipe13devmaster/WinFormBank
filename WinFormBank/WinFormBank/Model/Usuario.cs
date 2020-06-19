using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormBank.Model
{
    class Usuario
    {
        private string idNome;
        private string senha;
        private int idCliente;

        public Usuario() { }

        public Usuario(string idNome, string senha, int idCliente)
        {
            this.idNome = idNome;
            this.senha = senha;
            this.idCliente = idCliente;
        }

        public string IdNome { get => idNome; set => idNome = value; }
        public string Senha { get => senha; set => senha = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }

        public bool ValidaUsuario(Usuario usuario)
        {
            bool validado = true;
           
            if ((usuario.idNome == "") || (usuario.senha == ""))
            {
                validado = false;
            }
            return validado;
        }
    }
}
