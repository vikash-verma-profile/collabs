using System;
using System.Data;
using System.Data.SqlClient;


namespace ConsoleApp1
{


    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
    }

    public static class ConnectionStringProvider
    {
        // Replace with your actual connection string
        public static string ConnectionString { get; } = "Data Source=DESKTOP-CUO3FKB;Initial Catalog=sampleDBLTI;Integrated Security=True";
    }

    public class Class2
    {
        // Replace with your actual connection string
        static string connectionString = ConnectionStringProvider.ConnectionString;

        static void Main4(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. List Products");
                Console.WriteLine("3. Update Stock Quantity");
                Console.WriteLine("4. Delete Product");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice (1-5): ");
                int options = int.Parse(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        Product product = new Product();
                        Console.WriteLine("Enter the details of the new product:");
                        Console.Write("ProductID: ");
                        product.ProductID = int.Parse(Console.ReadLine());
                        Console.Write("ProductName: ");
                        product.ProductName = Console.ReadLine();
                        Console.Write("Price: ");
                        product.Price = decimal.Parse(Console.ReadLine());
                        Console.Write("StockQuantity: ");
                        product.StockQuantity = int.Parse(Console.ReadLine());
                        AddProduct(product);
                        break;
                    case 2:
                        ListProducts();
                        break;
                    case 3:
                        Console.Write("ProductName: ");
                        string ProductName = Console.ReadLine();
                        Console.Write("StockQuantity: ");
                        int StockQuantity = int.Parse(Console.ReadLine());
                        UpdateProductStock(ProductName, StockQuantity);
                        break;
                    case 4:
                        Console.Write("ProductID: ");
                        int ProductID = int.Parse(Console.ReadLine());
                        DeleteProduct(ProductID);
                        break;
                    case 5:
                        flag = false;
                        break;
                    default:
                        break;
                }
            }

        }
        public static void AddProduct(Product product)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "Select * from Products";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Products");

                // adding a new row for insertion
                DataRow row = ds.Tables["Products"].NewRow();
                row["ProductId"] = product.ProductID;
                row["ProductName"] = product.ProductName;
                row["Price"] = product.Price;
                row["StockQuantity"] = product.StockQuantity;
                //adding new row in dataset
                ds.Tables["Products"].Rows.Add(row);
                //update in database
                adapter.Update(ds, "Products");

            }
        }

        public static void ListProducts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "Select * from Products";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Products");
                Console.WriteLine("List of Products:");
                foreach (DataRow item in ds.Tables["Products"].Rows)
                {
                    Console.WriteLine($"ProductID: {item["ProductID"]}, ProductName: {item["ProductName"]},Price: {item["Price"]},StockQuantity: {item["StockQuantity"]}");
                }
            }
        }

        public static void UpdateProductStock(string productName, int newStockQuantity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "Select * from Products";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Products");
                foreach (DataRow item in ds.Tables["Products"].Rows)
                {
                    if (Convert.ToString(item["ProductName"]) == productName)
                    {
                        item["StockQuantity"] = newStockQuantity;
                        break;
                    }
                }
                //update in database
                adapter.Update(ds, "Products");
            }
        }

        public static void DeleteProduct(int productID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "Select * from Products";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Products");
                foreach (DataRow item in ds.Tables["Products"].Rows)
                {
                    if (Convert.ToInt32(item["ProductID"]) == productID)
                    {
                        item.Delete();
                        break;
                    }
                }
                //update in database
                adapter.Update(ds, "Products");
            }
        }

    }
}
