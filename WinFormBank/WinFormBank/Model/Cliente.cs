﻿using System;

namespace WinFormBank.Model
{
    class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public string Endereco { get; set; }
        public string Uf { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        public Cliente() { }

        public bool ValidaCliente(Cliente cliente)
        {
            bool validado = true;

            if ((cliente.Nome == "") || (cliente.Cpf.Length < 14) || (cliente.Nascimento.ToString() == "    -  -  ") || (cliente.Endereco == "")
                   || (cliente.Uf == "") || (cliente.Celular.Length < 15) || (cliente.Email == ""))
            {
                validado = false;
            }
            return validado;
        }
    }
}
