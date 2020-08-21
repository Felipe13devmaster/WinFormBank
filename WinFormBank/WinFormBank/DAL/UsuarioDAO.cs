using System;
using System.Data.SqlClient;
using WinFormBank.Util;
using WinFormBank.Model;
using System.Windows.Forms;
using System.Data;

namespace WinFormBank.DAL
{
    public class UsuarioDAO
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader dataReader;
        
        public UsuarioDAO()
        {
            try
            {
                connection = ConnectionFactory.connection();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro de conectar cliente Dao com o bd!");
            }
        }

        public void Salvar(Usuario usuario, bool validado, string cpf)
        {
            if (validado == true)
            {
                string sqlQuery =" DECLARE @RETORNA_ID_CLIENTE INT" +
                                 " SELECT @RETORNA_ID_CLIENTE = (SELECT ID FROM CLIENTE WHERE CPF = @CPF)" +  
                                 " INSERT INTO PERFIL (ID_PERFIL, SENHA, ID_CLIENTE)" +
                                 " VALUES(@NOME, @SENHA, @RETORNA_ID_CLIENTE)";

                try
                {
                    command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@CPF", cpf);
                    command.Parameters.AddWithValue("@NOME", usuario.IdNome);
                    command.Parameters.AddWithValue("@SENHA", usuario.Senha);
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro ao salvar usuario!" + e);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }

                MessageBox.Show("Bem vindo " + usuario.IdNome);
            }
            else
            {
                MessageBox.Show("Falta pouco, vamos lá!.");
            }
        }

        public bool VerificarLogin(string idNome, string senha)
        {
            bool tem = false;
            string sqlQuery = "SELECT * FROM PERFIL WHERE ID_PERFIL = @NOME AND SENHA = @SENHA";

            try
            {
                command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@NOME", idNome);
                command.Parameters.AddWithValue("@SENHA", senha);
                dataReader = command.ExecuteReader();

                if (dataReader.HasRows)//has rows retorna se tem linhas preenchidas no resultado da busca
                {
                    tem = true;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(" Erro ao verificar login " + e);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return tem;
        }
    }
}
