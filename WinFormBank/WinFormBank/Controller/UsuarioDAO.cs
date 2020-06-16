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

        public void salvar(Usuario usuario)
        {
            string sqlQuery = "declare @IDENTITY_CLIENTE INT" + 
                " SELECT @IDENTITY_CLIENTE = (SELECT TOP 1 ID_CLIENTE FROM CLIENTE ORDER BY ID_CLIENTE DESC)" +
                " INSERT INTO PERFIL(NOME_USUARIO, SENHA, ID_CLIENTE)" +
                " VALUES(@NOME, @SENHA, @IDENTITY_CLIENTE)";

            try
            {
                command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@NOME", usuario.Nome);
                command.Parameters.AddWithValue("@SENHA", usuario.Senha);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao salvar usuario!"+ e);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            MessageBox.Show("Bem vindo " + usuario.Nome);
        }

        public bool verificarLogin(string nome, string senha)
        {
            bool tem = false;
            string sqlQuery = "SELECT * FROM PERFIL WHERE NOME_USUARIO = @NOME AND SENHA = @SENHA";

            try
            {
                command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@NOME", nome);
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
