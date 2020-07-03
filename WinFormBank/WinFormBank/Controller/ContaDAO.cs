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
            catch (SqlException e)
            {
                MessageBox.Show("Erro de conectar cliente Dao com o bd! "+e);
            }
        }

        public void Salvar(bool validado, Conta conta, string cpf)
        {
            if (validado == true)
            {
                string sqlQuery = " DECLARE @RETORNA_ID_CLIENTE INT" +
                                 " SELECT @RETORNA_ID_CLIENTE = (SELECT ID FROM CLIENTE WHERE CPF = @CPF)" +
                                 " INSERT INTO CONTA (NUMERO, TIPO, SALDO, ID_CLIENTE)" +
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
                catch (SqlException e)
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

                MessageBox.Show("Esta é sua conta " + conta.Tipo + ": " + conta.Numero); 
            }
            else
            {
                MessageBox.Show("Erro ao gerar Conta!");
            }
        }

        public Cliente ConsultarDados(Cliente cliente, string idUsuario)
        {


            string sqlQuery = " DECLARE @RETORNA_ID_CLIENTE INT" +
                              " SELECT @RETORNA_ID_CLIENTE = (SELECT ID_CLIENTE FROM PERFIL WHERE ID_PERFIL = @ID_PERFIL)" +
                              " SELECT NOME FROM CLIENTE WHERE ID = @RETORNA_ID_CLIENTE";

            try
            {
                command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@ID_PERFIL", idUsuario);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    cliente.Nome = (string)dataReader["NOME"];
                }
                
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro ao consultar conta!" + e);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return cliente;
        }

        public Conta ConsultarDados(Conta conta, string idUsuario)
        {


            string sqlQuery = " DECLARE @RETORNA_ID_CLIENTE INT" +
                              " SELECT @RETORNA_ID_CLIENTE = (SELECT ID_CLIENTE FROM PERFIL WHERE ID_PERFIL = @ID_PERFIL)" +
                              " SELECT NUMERO, TIPO, SALDO FROM CONTA WHERE ID_CLIENTE = @RETORNA_ID_CLIENTE";

            try
            {   
                if(connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@ID_PERFIL", idUsuario);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    conta.Numero = (int)dataReader["NUMERO"];
                    conta.Tipo = (string)dataReader["TIPO"];
                    conta.Saldo = (decimal)dataReader["SALDO"];
                } 
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao consultar conta!" + e);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return conta;
        }

        public decimal ConsultarSaldo(int numConta)
        {
            decimal saldo = 0;
            string sqlQuery = " SELECT SALDO FROM CONTA " +
                              " WHERE NUMERO = @NUMCONTA";

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@NUMCONTA", numConta);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    saldo = (decimal)dataReader["SALDO"];
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao consultar saldo!" + e);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return saldo;
        }
    }
    
}

