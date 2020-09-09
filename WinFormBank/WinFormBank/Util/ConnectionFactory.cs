using System.Data.SqlClient;
using System.Data;

namespace WinFormBank.Util
{
    public class ConnectionFactory
    {
        public static SqlConnection sqlConnection = new SqlConnection();
        
        public static SqlConnection connection()
        {
            try
            {
                string dadosConexao = ("Data Source=LAPTOP-JK3T3A00;Initial Catalog=FUBANK;Integrated Security=True;");
                sqlConnection = new SqlConnection(dadosConexao);

                if(sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                return sqlConnection; 
            }
            catch (SqlException e)
            {
                // MessageBox.Show("Ocorreou o erro: "+ex);
                throw e;
            }
        } 
    }
}
