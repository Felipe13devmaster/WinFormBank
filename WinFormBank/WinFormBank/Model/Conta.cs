using System;

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

        public int Numero { get => numero; set => numero = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }

        public Conta CriarConta()
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            Random numAleatorio = new Random();
            int numConta = numAleatorio.Next(10000, 100000);
            contaCorrente.Numero = numConta;
            this.saldo = 0;
            return contaCorrente;
        }
    }
}
