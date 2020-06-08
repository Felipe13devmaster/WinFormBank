using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormBank.Model
{
    class Usuario
    {
        private int id;
        private string nome;
        private string senha;
        private int idCliente;

        public Usuario() { }

        public Usuario(int id, string nome, string senha, int idCliente)
        {
            this.id = id;
            this.nome = nome;
            this.senha = senha;
            this.idCliente = idCliente;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Senha { get => senha; set => senha = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
    }
}
