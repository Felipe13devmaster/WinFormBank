using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormBank.Model;
using WinFormBank.Util;

namespace WinFormBank.Controller
{
    class ContaDAO
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader dataReader;

        public ContaDAO()
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

        public void Salvar(bool validado, Conta conta, string cpf)
        {
            if (validado == true)
            {
                string sqlQuery = " DECLARE @RETORNA_ID_CLIENTE INT" +
                                 " SELECT @RETORNA_ID_CLIENTE = (SELECT ID FROM CLIENTE WHERE CPF = @CPF)" +
                                 " INSERT INTO CONTA (CONTA, TIPO, SALDO, ID_CLIENTE)" +
                                 " VALUES(@CONTA, @TIPO, @SALDO, @RETORNA_ID_CLIENTE)";

                try
                {
                    command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@CONTA", conta.Numero);
                    command.Parameters.AddWithValue("@TIPO", conta.Tipo);
                    command.Parameters.AddWithValue("@SALDO", conta.Saldo);
                    command.Parameters.AddWithValue("@CPF", cpf);
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro ao salvar conta!" + e);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }

                MessageBox.Show("Esta é sua conta " + conta.Tipo + ": " + conta.Numero); ;
            }
            else
            {
                MessageBox.Show("Erro ao gerar Conta!");
            }
        }
    }
}

