using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormBank.Model
{
    class Cliente
    {
        private int id;
        private string nome;
        private string cpf;
        private DateTime nascimento;
        private string endereco;
        private string uf;
        private string celular;
        private string email;

        public Cliente() { }

        public Cliente(int id, string nome, string cpf, DateTime nascimento, string endereco, string uf, string celular, string email)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.nascimento = nascimento;
            this.endereco = endereco;
            this.uf = uf;
            this.celular = celular;
            this.email = email;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public DateTime Nascimento { get => nascimento; set => nascimento = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Email { get => email; set => email = value; }
    }
}
