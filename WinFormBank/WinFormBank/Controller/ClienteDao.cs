using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormBank.Util;
using WinFormBank.Model;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormBank.Controller
{
    class ClienteDao
    {
        private Cliente cliente;
        private SqlConnection connection;
        private SqlCommand command;

        public ClienteDao()
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

        public void salvar(Cliente cliente)
        {
            string sqlQuery = @"INSERT INTO CLIENTE(ID_CLIENTE, NOME, CPF, NASCIMENTO, ENDERECO, UF, CELULAR, EMAIL)" +
                " VALUES(?, ?, ?, ?, ?, ?, ?, ?)";

            try
            {
                command = new SqlCommand(sqlQuery);
                command.Parameters.AddWithValue("@ID_CLIENTE", cliente.Id);
                command.Parameters.AddWithValue("@NOME", cliente.Nome);
                command.Parameters.AddWithValue("@CPF", cliente.Cpf);
                command.Parameters.AddWithValue("@NASCIMENTO", cliente.Nascimento);
                command.Parameters.AddWithValue("@ENDERECO", cliente.Endereco);
                command.Parameters.AddWithValue("@UF", cliente.Uf);
                command.Parameters.AddWithValue("@CELULAR", cliente.Celular);
                command.Parameters.AddWithValue("@EMAIL", cliente.Email);
                command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show("Erro ao salvar cliente!");
            }
        }
    }
}
