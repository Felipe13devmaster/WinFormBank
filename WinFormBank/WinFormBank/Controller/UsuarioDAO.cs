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
            string sqlQuery = @"INSERT INTO PERFIL(ID_USUARIO, NOME_USUARIO, SENHA, ID_CLIENTE)" +
               " VALUES(?, ?, ?, ?)";

            try
            {
                command = new SqlCommand(sqlQuery);
                command.Parameters.AddWithValue("ID_USUARIO", usuario.Id);
                command.Parameters.AddWithValue("NOME_USUARIO", usuario.Nome);
                command.Parameters.AddWithValue("SENHA", usuario.Senha);
                command.Parameters.AddWithValue("ID_CLIENTE", usuario.IdCliente);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao salvar usuario!");
            }
        }
    }
}
