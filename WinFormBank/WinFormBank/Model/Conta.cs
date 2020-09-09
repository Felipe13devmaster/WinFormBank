using System;

namespace WinFormBank.Model
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public decimal Saldo { get; set; }
        public int IdCliente { get; set; }

        public virtual Conta CriarConta()
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            Random numAleatorio = new Random();
            int numConta = numAleatorio.Next(10000, 100000);
            contaCorrente.Numero = numConta;
            Saldo = 0;
            return contaCorrente;
        }
    }
}
