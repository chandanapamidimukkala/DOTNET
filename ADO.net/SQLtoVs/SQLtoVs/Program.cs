using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace SQLtoVs
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr= @"Data Source = BLT1075\SQLEXPRESS2014; Initial Catalog = employeedb; Integrated Security = True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                string querystr = "select * from Course";
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(querystr, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}", reader[0], reader[1], reader[2]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadKey();
            }
        }
    }
}
