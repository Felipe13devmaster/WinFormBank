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

        public bool Depositar(int numConta, decimal valor)
        {
            bool aprovado = true;
            string sqlQuery = " UPDATE CONTA " +
                              " SET SALDO = @SALDO " +
                              " WHERE NUMERO = @CONTA ";

            try
            {
                command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@CONTA", numConta);
                command.Parameters.AddWithValue("@SALDO", valor);
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro ao depositar!" + e);
                aprovado = false;
                return aprovado;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return aprovado;
        }
    }
}
