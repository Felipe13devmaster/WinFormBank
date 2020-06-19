using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormBank.Model
{
    class ContaCorrente:Conta
    {
        public ContaCorrente() { }

        public bool PagarBoleto(string numBoleto, decimal valor) 
        {
            bool aprovado = false;

            return aprovado;
        }

        public bool Transferir(int numContaDestino, decimal valorTransf) 
        {
            bool aprovado = false;

            return aprovado;
        }

        public bool Sacar(int numConta, decimal valorSaque) 
        {
            bool aprovado = false;

            return aprovado;
        }

        public bool Depositar(int numConta, decimal valor) 
        {
            bool aprovado = false;

            return aprovado;
        }

        public bool TransferirParaPoupanca(int numContaPoupanca, decimal valorTransf)
        {
            bool aprovado = false;

            return aprovado;
        }
    }
}
