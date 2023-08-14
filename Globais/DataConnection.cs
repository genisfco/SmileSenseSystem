using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Globais
{
    public class DataConnection
    {
        public static SqlConnection msConnection;

        public static string ConnectionString { get; set; }

        public static SqlConnection ConexaoBanco()
        {
            string connection_sql = ConnectionString;            

            SqlConnection msConnection = new SqlConnection();
            msConnection.ConnectionString = connection_sql;
            try { 
                msConnection.Open();
                return msConnection;
            } 
            catch (Exception err) { 
                MessageBox.Show(err.Message, "Erro de Conexão de Dados");
                return null;
            }        
        }
    }
}


