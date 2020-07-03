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
    class ContaCorrenteDAO:ContaDAO
    {
        // public int ConsultarSaldo() { }
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader dataReader;

        public ContaCorrenteDAO()
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

        public bool Depositar(int numConta, decimal valorDeposito)
        {
            bool aprovado = true;
            string sqlQuery = " UPDATE CONTA " +
                              " SET SALDO = @SALDO + SALDO " +
                              " WHERE NUMERO = @CONTA ";

            try
            {
                command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@CONTA", numConta);
                command.Parameters.AddWithValue("@SALDO", valorDeposito);
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro ao depositar!" + e);
                aprovado = false;
                return aprovado;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return aprovado;
        }

        public bool PagarBoleto(string numBoleto, decimal valor)
        {
            bool aprovado = false;

            return aprovado;
        }

        public bool Transferir(int numContaDestino, decimal valorTransf)
        {
            bool aprovado = false;

            return aprovado;
        }

        public bool Sacar(int numConta, decimal saldo, decimal valorSaque)
        {
            bool aprovado = true;
            string sqlQuery = " UPDATE CONTA " +
                              " SET SALDO = SALDO - @VALORSAQUE " +
                              " WHERE NUMERO = @CONTA ";

            try
            {
                if (valorSaque <= saldo)
                {
                    command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@CONTA", numConta);
                    command.Parameters.AddWithValue("@VALORSAQUE", valorSaque);
                    command.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Valor de saque indisponivel!");
                    aprovado = false;
                }  
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro ao sacar!" + e);
                aprovado = false;
                return aprovado;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return aprovado;
        }

        public bool TransferirParaPoupanca(int numContaPoupanca, decimal valorTransf)
        {
            bool aprovado = false;

            return aprovado;
        }
    }
}
