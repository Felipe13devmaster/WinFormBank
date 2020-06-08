﻿using System;
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

        public Conta() { }

        public Conta(int numero, string tipo, decimal saldo)
        {
            this.numero = numero;
            this.tipo = tipo;
            this.saldo = saldo;
        }

        public int Numero { get => numero; set => numero = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }
    }
}
