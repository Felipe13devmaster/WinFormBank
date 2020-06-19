using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WinFormBank.Util;
using WinFormBank.Model;
using System.Windows.Forms;
using System.Data;

namespace WinFormBank.Controller
{
    class UsuarioDAO
    {
        private Usuario usuario;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader dataReader;
        
        public UsuarioDAO()
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

        public void Salvar(Usuario usuario, bool validado, int idCliente)
        {
            if (validado == true)
            {
                string sqlQuery = " INSERT INTO PERFIL_ACESSO (ID_PERFIL, SENHA, ID_CLIENTE)" +
                " VALUES(@NOME, @SENHA, @ID_CLIENTE)";

                try
                {
                    command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@NOME", usuario.IdNome);
                    command.Parameters.AddWithValue("@SENHA", usuario.Senha);
                    command.Parameters.AddWithValue("@ID_CLIENTE", idCliente);
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
            string sqlQuery = "SELECT * FROM PERFIL_ACESSO WHERE ID_PERFIL = @NOME AND SENHA = @SENHA";

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

            return tem;
        }
    }
}
