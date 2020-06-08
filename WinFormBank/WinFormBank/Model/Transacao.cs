using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormBank.Model
{
    class Transacao
    {
        private int id;
        private string tipo;
        private decimal valor;
        private string dataHora;
        private int numeroConta;

        public Transacao() { }

        public Transacao(int id, string tipo, decimal valor, string dataHora, int numeroConta)
        {
            this.id = id;
            this.tipo = tipo;
            this.valor = valor;
            this.dataHora = dataHora;
            this.numeroConta = numeroConta;
        }

        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public string DataHora { get => dataHora; set => dataHora = value; }
        public int NumeroConta { get => numeroConta; set => numeroConta = value; }
    }
}
