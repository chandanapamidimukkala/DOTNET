using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Chandu;Integrated Security=True;
                            Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;
                            ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(constr))
            {
                try
                {
                    string querystr = "select * from student";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(querystr, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}", reader[0], reader[1], reader[2]);
                    }
                    reader.Close();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadKey();
            }
        }
    }
}
