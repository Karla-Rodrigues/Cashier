using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cashier.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private static List<Order> oStatic = new List<Order>();

        private static List<Order> oRepository = new List<Order>()
        {

        };
        public IQueryable<Order> Orders => new List<Order> {
              new Order
              {
                  OrdCode = 20001,
                  OrdCustomer = 00001,
                  OrdStatus =   "PA",
                  OrdQtdItems = 1,
                  OrdDateOrder ="01-04-01",
                  OrdDateCancel = " "
              },
              new Order
              {
                  OrdCode = 20002,
                  OrdCustomer = 99912,
                  OrdStatus =   "PA",
                  OrdQtdItems = 1,
                  OrdDateOrder ="01-04-01",
                  OrdDateCancel = " "
              },
              new Order
              {
                  OrdCode = 20003,
                  OrdCustomer = 99913,
                  OrdStatus =   "PA",
                  OrdQtdItems = 1,
                  OrdDateOrder ="01-04-01",
                  OrdDateCancel = " "
              },
              new Order
              {
                  OrdCode = 20004,
                  OrdCustomer =  99914,
                  OrdStatus =    "CA",
                  OrdQtdItems =  1,
                  OrdDateOrder = "01-04-01",
                  OrdDateCancel = " "
              },
              new Order
              {
                  OrdCode = 20005,
                  OrdCustomer =  99914,
                  OrdStatus =    "PA",
                  OrdQtdItems =  1,
                  OrdDateOrder = "01-04-01",
                  OrdDateCancel = " "
              },
              new Order
              {
                  OrdCode = 20006,
                  OrdCustomer =  99914,
                  OrdStatus =    "PA",
                  OrdQtdItems =  1,
                  OrdDateOrder = "01-04-01",
                  OrdDateCancel = " "
              },
              new Order
              {
                  OrdCode = 20007,
                  OrdCustomer =  99915,
                  OrdStatus =    "CA",
                  OrdQtdItems =  1,
                  OrdDateOrder = "01-04-01",
                  OrdDateCancel = " "
              },
              new Order
              {
                  OrdCode = 20008,
                  OrdCustomer = 99921,
                  OrdStatus =   "PA",
                  OrdQtdItems = 1,
                  OrdDateOrder ="01-04-01",
                  OrdDateCancel = " "
              },
              new Order
              {
                  OrdCode = 20009,
                  OrdCustomer =  00001,
                  OrdStatus =    "PA",
                  OrdQtdItems =  2,
                  OrdDateOrder = "01-04-01",
                  OrdDateCancel = " "
              },
              new Order
              {
                  OrdCode = 20010,
                  OrdCustomer = 99921,
                  OrdStatus =   "PA",
                  OrdQtdItems = 3,
                  OrdDateOrder ="01-04-01",
                  OrdDateCancel = " "
              },
              new Order
              {
                  OrdCode = 20011,
                  OrdCustomer =  99922,
                  OrdStatus =    "PA",
                  OrdQtdItems =  1,
                  OrdDateOrder = "01-04-01",
                  OrdDateCancel = " "
              },
              new Order
              {
                  OrdCode = 20012,
                  OrdCustomer =  99923,
                  OrdStatus =    "PA",
                  OrdQtdItems =  1,
                  OrdDateOrder = "01-04-01",
                  OrdDateCancel = " "
              },
              new Order
              {
                  OrdCode = 20013,
                  OrdCustomer = 99923,
                  OrdStatus =   "PA",
                  OrdQtdItems = 1,
                  OrdDateOrder ="01-04-01",
                  OrdDateCancel = " "
              },
              new Order
              {
                  OrdCode = 20014,
                  OrdCustomer = 99924,
                  OrdStatus =   "PA",
                  OrdQtdItems = 1,
                  OrdDateOrder ="01-04-01",
                  OrdDateCancel = " "
              },
              new Order
              {
                  OrdCode = 20015,
                  OrdCustomer = 99925,
                  OrdStatus =   "PA",
                  OrdQtdItems = 1,
                  OrdDateOrder ="01-04-01",
                  OrdDateCancel = " "
              },
              new Order
              {
                  OrdCode = 20016,
                  OrdCustomer = 99925,
                  OrdStatus =   "PA",
                  OrdQtdItems = 2,
                  OrdDateOrder ="01-04-01",
                  OrdDateCancel = " "
              }
        }.AsQueryable<Order>();
    }
}
