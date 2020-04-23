using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Dal
{
    public class Conexao
    {
        string connectionString = ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString;

        SqlConnection con = new SqlConnection(); 
        public Conexao()
        {
            //"server=127.0.0.1;user id=root;database=bd";
            con.ConnectionString = connectionString; 
        }
        //Metodo de conectar no banco   
        public SqlConnection Conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open(); 
            }
            return con; 
        }
        //Metodo de desconectar do banco
        public void desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close(); 
            }
        }
    }
}
