using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormBank.Model
{
    class Conta
    {
        private int numero;
        private string tipo;
        private decimal saldo;
        private int idCliente;

        public Conta() { }

        public Conta(int numero, string tipo, decimal saldo, int idCliente)
        {
            this.numero = numero;
            this.tipo = tipo;
            this.saldo = saldo;
            this.idCliente = idCliente;
        }

        public Conta(int numConta, string tipoConta, int idCliente) 
        {
            this.numero = numConta;
            this.tipo = tipoConta;
            this.saldo = 0;
            this.idCliente = idCliente;
        }

        public int Numero { get => numero; set => numero = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }

        protected int CriarNumConta()
        {
            Random numAleatorio = new Random();
            int numConta = numAleatorio.Next(10000,100000);

            return numConta;
        }
    }
}
