using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Cashier.Models;
using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;

namespace Cashier.Controllers
{
    public class CustomerController : Controller
    {
        private const string V = "proc_customer_out";
        public ICustomerRepository repository;
        public CustomerController(ICustomerRepository repo)
        {
            repository = repo;
        }

        public ViewResult List()
        {
            List<Customer> customerList = new List<Customer>();

            //using (SqlConnection con = new SqlConnection("User ID=COMP214_M19_002_7; Password=password; Data Source=199.212.26.208:1521/SQLD"))
            //using (SqlConnection con = new SqlConnection("User ID=hr; Password=hr; Data Source=localhost:1521/orclDB"))

            using (OracleConnection con = new OracleConnection("User ID=karla;PASSWORD=password;Data Source=localhost:1521/orclDB;"))
            {
                string queryString = "SELECT * from comm_Customers";

                OracleCommand command = new OracleCommand(queryString, con);
                con.Open();
                OracleDataReader reader;
                reader = command.ExecuteReader();

                // Always call Read before accessing data.
                while (reader.Read())
                {
                    var customer = new Customer();

                    customer.CustId = Convert.ToInt32(reader.GetInt32(reader.GetOrdinal("CUST_ID#")));
                    customer.CustEmail = reader.GetString(reader.GetOrdinal("CUST_EMAIL"));
                    customer.CustFirstName = reader.GetString(reader.GetOrdinal("CUST_FIRST_NAME"));
                    customer.CustLastName = reader.GetString(reader.GetOrdinal("CUST_LAST_NAME"));
                    //customer.CustPhone = Convert.ToInt32(reader.GetInt32(reader.GetOrdinal("CUST_PHONE")));

                    customerList.Add(customer);
                }
                    reader.Close(); // close after read
                
            }
            return View(customerList);
        }

        public ViewResult Customer(int custId)
        {
            var customer = new Customer();

            using (OracleConnection conn = new OracleConnection("User ID=karla;PASSWORD=password;Data Source=localhost:1521/orclDB;"))
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                cmd.CommandText = "COMM_CUSTOMER_DETAIL";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("CUST_ID#", OracleDbType.Int32).Value = custId;
                cmd.Parameters.Add("CUST_EMAIL", OracleDbType.Varchar2, 30).Direction = ParameterDirection.ReturnValue;
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    
                    //customer.CustEmail = Convert.ToString(cmd.Parameters["cust_email"].Value);
                    customer.CustEmail = cmd.Parameters["CUST_EMAIL"].Value.ToString();
                    customer.CustFirstName = "Karla";

                    //customer.CustId = Convert.ToInt32(reader.GetInt32(reader.GetOrdinal("CUSTOMERID")));
                    //customer.CustFirstName = reader.GetString(reader.GetOrdinal("NAME"));
                    //customer.CustFirstName = reader.GetString(reader.GetOrdinal("SURNAME"));
                    //customer.CustPhone = Convert.ToInt32(reader.GetInt32(reader.GetOrdinal("PHONE")));
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Exception: {0}", ex.ToString());
                }
                conn.Close();
            }
            return View(customer);
        }
    }
}