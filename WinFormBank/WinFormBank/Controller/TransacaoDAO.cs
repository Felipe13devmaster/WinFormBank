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
    class TransacaoDAO
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader dataReader;

        public TransacaoDAO()
        {
            try
            {
                connection = DataAccess.connection();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro de conectar cliente Dao com o bd! " + e);
            }
        }

        public List <Transacao> ConsultarDados(int numConta)
        {
            List<Transacao> listaTransacoes = new List<Transacao>();
            string sqlQuery = "SELECT * FROM TRANSACAO WHERE NUMERO_CONTA = @NUM_CONTA";
            
            try
            {
                command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@NUM_CONTA", numConta);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string tipo = (string)dataReader["TIPO"];
                    string descricao = (string)dataReader["DESCRICAO"]; 
                    decimal valor = (Decimal)dataReader["VALOR"];
                    DateTime dataHora = (DateTime)dataReader["DATA_HORA"];
                    Transacao transacao = new Transacao(tipo, descricao, valor, dataHora);
                    listaTransacoes.Add(transacao);
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro ao consultar lista de transacoes!" + e);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return listaTransacoes;
        }

        public void RegistrarDeposito(Transacao transacao)
        {
            string sqlQuery = " INSERT INTO TRANSACAO (TIPO, DESCRICAO, VALOR, DATA_HORA, NUMERO_CONTA) " +
                              " VALUES (@TIPO, @DESCRICAO, @VALOR, @DATA_HORA, @NUMERO_CONTA)";

            try
            {
                command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@TIPO", transacao.Tipo);
                command.Parameters.AddWithValue("@DESCRICAO", transacao.Descricao);
                command.Parameters.AddWithValue("@VALOR", transacao.Valor);
                command.Parameters.AddWithValue("@DATA_HORA", transacao.DataHora);
                command.Parameters.AddWithValue("@NUMERO_CONTA", transacao.NumeroConta);
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro ao registrar deposito " + e);
            }
        }
    }
}
