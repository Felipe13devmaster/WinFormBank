using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormBank.Model
{
    class ContaCorrente:Conta
    {
        public ContaCorrente() 
        {
            this.Tipo = "Corrente";
        }   
    }
}
