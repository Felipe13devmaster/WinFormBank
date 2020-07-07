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
        private string descricao;
        private decimal valor;
        private DateTime dataHora;
        private int numeroConta;

        public Transacao() { }

        public Transacao(string tipo, string descricao, decimal valor, DateTime dataHora)
        {
            this.tipo = tipo;
            this.descricao = descricao;
            this.valor = valor;
            this.dataHora = dataHora;
        }

        public Transacao(int id, string tipo, string descricao, decimal valor, DateTime dataHora, int numeroConta)
        {
            this.id = id;
            this.tipo = tipo;
            this.descricao = descricao;
            this.valor = valor;
            this.dataHora = dataHora;
            this.numeroConta = numeroConta;
        }

        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public DateTime DataHora { get => dataHora; set => dataHora = value; }
        public int NumeroConta { get => numeroConta; set => numeroConta = value; }
    }
}
