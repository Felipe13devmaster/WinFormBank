﻿using System;

namespace WinFormBank.Model
{
    public class Transacao
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataHora { get; set; }
        public int NumeroConta { get; set; }

        public Transacao()
        {

        }

        public Transacao(string tipo, string descricao, decimal valor, DateTime dataHora)
        {
            this.Tipo = tipo;
            this.Descricao = descricao;
            this.Valor = valor;
            this.DataHora = dataHora;
        }
    }
}
