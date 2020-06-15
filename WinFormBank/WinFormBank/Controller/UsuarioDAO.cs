using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WinFormBank.Util;
using WinFormBank.Model;
using System.Windows.Forms;

namespace WinFormBank.Controller
{
    class UsuarioDAO
    {
        private Usuario usuario;
        private SqlConnection connection;
        private SqlCommand command;

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
                " VALUES(@NOME_USUARIO, @SENHA, @IDENTITY_CLIENTE)";

            try
            {
                command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@NOME_USUARIO", usuario.Nome);
                command.Parameters.AddWithValue("@SENHA", usuario.Senha);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao salvar usuario!"+ e);
            }

            MessageBox.Show("Bem vindo " + usuario.Nome);
            
        }
    }
}
