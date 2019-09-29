using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cashier.Models;
using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;

namespace Cashier.Controllers
{
    public class ProductController : Controller
    {
        public IProductRepository repository;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult List()
        {
            List<Product> productList = new List<Product>();

            //using (SqlConnection con = new SqlConnection("User ID=COMP214_M19_002_7; Password=password; Data Source=199.212.26.208:1521/SQLD"))
            //using (SqlConnection con = new SqlConnection("User ID=hr; Password=hr; Data Source=localhost:1521/orclDB"))

            using (OracleConnection con = new OracleConnection("User ID=karla;PASSWORD=password;Data Source=localhost:1521/orclDB;"))
            {
                string queryString = "SELECT * from comm_Products";

                OracleCommand command = new OracleCommand(queryString, con);
                con.Open();
                OracleDataReader reader;
                reader = command.ExecuteReader();

                // Always call Read before accessing data.
                while (reader.Read())
                {
                    var product = new Product();

                    product.ProdCode = Convert.ToInt32(reader.GetInt32(reader.GetOrdinal("PROD_CODE#")));
                    product.ProdCategory = reader.GetString(reader.GetOrdinal("PROD_CATEGORY"));
                    product.ProdShort = reader.GetString(reader.GetOrdinal("PROD_SHORT"));
                    product.ProdLong = reader.GetString(reader.GetOrdinal("PROD_LONG"));
                    product.ProdRetail = Convert.ToInt32(reader.GetInt32(reader.GetOrdinal("PROD_RETAIL")));
                    product.ProdCost = Convert.ToInt32(reader.GetInt32(reader.GetOrdinal("PROD_COST")));
                    product.ProdDiscount = Convert.ToInt32(reader.GetInt32(reader.GetOrdinal("PROD_DISCOUNT")));
                    product.ProdStock = Convert.ToInt32(reader.GetInt32(reader.GetOrdinal("PROD_STOCK")));
                    product.ProdSupplier = reader.GetString(reader.GetOrdinal("PROD_SUPPLIER"));

                    productList.Add(product);
                }
                reader.Close(); // close after read

            }
            return View(productList);
        }

        public ViewResult Stock()
        {
            List<Product> productList = new List<Product>();

            //using (SqlConnection con = new SqlConnection("User ID=COMP214_M19_002_7; Password=password; Data Source=199.212.26.208:1521/SQLD"))
            //using (SqlConnection con = new SqlConnection("User ID=hr; Password=hr; Data Source=localhost:1521/orclDB"))

            using (OracleConnection con = new OracleConnection("User ID=karla;PASSWORD=password;Data Source=localhost:1521/orclDB;"))
            {
                string queryString = "SELECT * from comm_Products ORDER BY prod_supplier";

                OracleCommand command = new OracleCommand(queryString, con);
                con.Open();
                OracleDataReader reader;
                reader = command.ExecuteReader();

                // Always call Read before accessing data.
                while (reader.Read())
                {
                    var product = new Product();

                    product.ProdCode = Convert.ToInt32(reader.GetInt32(reader.GetOrdinal("PROD_CODE#")));
                    product.ProdCategory = reader.GetString(reader.GetOrdinal("PROD_CATEGORY"));
                    product.ProdShort = reader.GetString(reader.GetOrdinal("PROD_SHORT"));
                    product.ProdLong = reader.GetString(reader.GetOrdinal("PROD_LONG"));
                    product.ProdRetail = Convert.ToInt32(reader.GetInt32(reader.GetOrdinal("PROD_RETAIL")));
                    product.ProdCost = Convert.ToInt32(reader.GetInt32(reader.GetOrdinal("PROD_COST")));
                    product.ProdDiscount = Convert.ToInt32(reader.GetInt32(reader.GetOrdinal("PROD_DISCOUNT")));
                    product.ProdStock = Convert.ToInt32(reader.GetInt32(reader.GetOrdinal("PROD_STOCK")));
                    product.ProdSupplier = reader.GetString(reader.GetOrdinal("PROD_SUPPLIER"));

                    productList.Add(product);
                }
                reader.Close(); // close after read

            }
            return View(productList);
        }
    }
}