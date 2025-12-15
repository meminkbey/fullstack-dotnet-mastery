using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _10_Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net 
            Console.WriteLine("***** C# DATABASE PRODUCT-CATEGORY INFORMATION SYSTEM");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("1-Categories");
            Console.WriteLine("2-Products");
            Console.WriteLine("3-Orders");
            Console.WriteLine("4-Exit");
            Console.Write("Insert the number of the table to list it: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("---------------------------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;initial Catalog=CSharpMasteryDb;integrated security=true ");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            
            foreach(DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }
            
            connection.Close();





            Console.Read();
        }
    }
}
