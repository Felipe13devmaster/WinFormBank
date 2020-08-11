using System;

namespace WinFormBank.Model
{
    class Conta
    {
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public decimal Saldo { get; set; }
        public int IdCliente { get; set; }
        public Conta() { }

        public Conta CriarConta()
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            Random numAleatorio = new Random();
            int numConta = numAleatorio.Next(10000, 100000);
            contaCorrente.Numero = numConta;
            this.Saldo = 0;
            return contaCorrente;
        }
    }
}
