using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_DatabaseCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Category Adding

            //Console.WriteLine("***** MENU ORDER PANEL *****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");
            //Console.Write("Category name: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;initial catalog=CSharpMasteryDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Category Name succesfully added!");

            #endregion

            #region Product add

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Product Name: ");
            //productName = Console.ReadLine();

            //Console.Write("Product Price: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;initial catalog=CSharpMasteryDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)",connection); ;
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Product succesfully added!");
            #endregion

            #region Product list

            //SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;initial catalog=CSharpMasteryDb;" +
            //    "" + "integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("select * from TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.WriteLine(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Product delete

            //Console.Write("Enter the product you want to delete: ");
            //string productName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data source=.\\SQLEXPRESS;initial catalog=CSharpMasteryDb;" +
            //    "integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("delete from TblProduct Where ProductName = @productName"
            //    ,connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine($"{productName} succesfully deleted");


            #endregion

            #region product update

            Console.Write("Id of the product to update: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("New name of product: ");
            string productName = Console.ReadLine();

            Console.Write("Price of the new product: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data source=.\\SQLEXPRESS;initial catalog=CSharpMasteryDb;" +
                "integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblProduct set " +
                "ProductName=@productName, ProductPrice=@productPrice where ProductId=@productId",connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Succesfully updated!");

            #endregion



            Console.Read();
        }
    }
}
