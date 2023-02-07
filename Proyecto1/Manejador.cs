using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto1
{
    public class Manejador
    {
        public static string  connectionstring = "Data Source=DESKTOP-HPHJBO6;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection = new SqlConnection(connectionstring);
        

        SqlCommand comand = new SqlCommand("Select * from Usuario", connection);
        connection.Open();
        SqlDataReader reader = comand.ExecuteReader();
            if (reader.HasRows)
                 {
                 while(reader.Read())
                {
                Console.WriteLine(reader.GetInt64(0)); 
                 }
            

            connection.Close();
        }
    }
}
