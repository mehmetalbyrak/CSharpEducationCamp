using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ado.Net
            Console.WriteLine("********** C# Database-Based Product Category Information System *********");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("1- Categories");
            Console.WriteLine("2- Products");
            Console.WriteLine("3- Orders");
            Console.WriteLine("4- Exit");
            Console.WriteLine("Please enter the number corresponding to the action you would like to perform");
            tableNumber = Console.ReadLine();
            Console.WriteLine("---------------------------------------------");

            SqlConnection sqlConnection = new SqlConnection(@"Server=DESKTOP-LAM2LI6\SQLEXPRESS; Initial Catalog=EducationCampDB; Integrated Security=True; TrustServerCertificate=True");
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("Select * from Categories", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }


            Console.Read();
        }
    }
}
