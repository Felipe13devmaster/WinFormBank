using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormBank.Util;
using WinFormBank.Model;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace WinFormBank.Controller
{
    class ContaCorrenteDAO
    {
        // public int ConsultarSaldo() { }
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader dataReader;

        public ContaCorrenteDAO()
        {
            try
            {
                connection = DataAccess.connection();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro de conectar cliente Dao com o bd!");
            }
        }

    }
}
