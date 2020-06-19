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
    class ClienteDAO
    {
        private Cliente cliente;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader dataReader;

        public ClienteDAO()
        {
            try
            {
                connection = DataAccess.connection();
            }
            catch(Exception e)
            {
                MessageBox.Show("Erro de conectar cliente Dao com o bd!");            
            }
        }

        public void Salvar(Cliente cliente, bool validado)
        {
            if (validado == true)
            {
                string sqlQuerySave = "INSERT INTO CLIENTE( NOME, CPF, NASCIMENTO, ENDERECO, UF, CELULAR, EMAIL)" +
                " VALUES( @NOME, @CPF, @NASCIMENTO, @ENDERECO, @UF, @CELULAR, @EMAIL)";

                try
                {
                    command = new SqlCommand(sqlQuerySave, connection);
                    command.Parameters.AddWithValue("@NOME", cliente.Nome);
                    command.Parameters.AddWithValue("@CPF", cliente.Cpf);
                    command.Parameters.AddWithValue("@NASCIMENTO", cliente.Nascimento.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@ENDERECO", cliente.Endereco);
                    command.Parameters.AddWithValue("@UF", cliente.Uf);
                    command.Parameters.AddWithValue("@CELULAR", cliente.Celular);
                    command.Parameters.AddWithValue("@EMAIL", cliente.Email);
                    command.ExecuteNonQuery(); 
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro ao salvar cliente!" + e);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor preencha todos os campos.");
            }
        }

        public int PegaIdCliente()
        {
            int idCliente = 0;
            string sqlQuery = "SELECT ID FROM CLIENTE WHERE CPF = @CPF ";
            string resultado = "";

            try
            {
                command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@CPF", cliente.Cpf);
                dataReader = command.ExecuteReader();
                resultado = dataReader.GetString(0);
                idCliente = Convert.ToInt32(resultado);
            }
            catch (SqlException)
            {

                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return idCliente;
        }
    }
}
