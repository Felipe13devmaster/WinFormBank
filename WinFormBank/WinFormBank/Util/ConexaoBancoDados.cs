using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WinFormBank.Util
{
    class DataAccess
    {
        public static SqlConnection sqlConnection = new SqlConnection();
        
        public static SqlConnection connection()
        {
            try
            {
                string dadosConexao = ("Data Source=DESKTOP-IQV848Q;Initial Catalog=FUBANK;Integrated Security=True;");
                sqlConnection = new SqlConnection(dadosConexao);

                if(sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                return sqlConnection; 
            }
            catch (SqlException ex)
            {
                // MessageBox.Show("Ocorreou o erro: "+ex);
                throw ex;
            }
        } 
    }
}
