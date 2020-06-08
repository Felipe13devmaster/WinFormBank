using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormBank.Model
{
    class Agencia
    {
        private int idCliente;
        private int numeroConta;

        public Agencia() { }

        public Agencia(int idCliente, int numeroConta)
        {
            this.idCliente = idCliente;
            this.numeroConta = numeroConta;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int NumeroConta { get => numeroConta; set => numeroConta = value; }
    }
}
