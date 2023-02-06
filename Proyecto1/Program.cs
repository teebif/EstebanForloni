using System.Data.SqlClient;

public class Program
{
    static void Main(string[] args)
    {
        string connectionstring = "Data Source=DESKTOP-HPHJBO6;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection = new SqlConnection(connectionstring);
    }
}