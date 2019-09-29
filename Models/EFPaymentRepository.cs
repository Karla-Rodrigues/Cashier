using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cashier.Models
{
    public class EFPaymentRepository : IPaymentRepository
    {
        private static List<Item> pStatic = new List<Item>();

        private static List<Payment> pRepository = new List<Payment>()
        {

        };
        public IQueryable<Payment> Payments => new List<Payment> {
           new Payment {PayOrder=20001,PayCustomer =00001,PayMethod = "CC",PayQtdItems =1,PayPayDate = "01-04-01"},
             new Payment {PayOrder=20002,PayCustomer =99912,PayMethod = "CC",PayQtdItems =1,PayPayDate = "01-04-01"},
             new Payment {PayOrder=20003,PayCustomer =99913,PayMethod = "CC",PayQtdItems =1,PayPayDate = "01-04-01"},
             new Payment {PayOrder=20004,PayCustomer =99914,PayMethod = "CH",PayQtdItems =1,PayPayDate = "01-04-01"},
             new Payment {PayOrder=20005,PayCustomer =99914,PayMethod = "DC",PayQtdItems =1,PayPayDate = "01-04-01"},
             new Payment {PayOrder=20006,PayCustomer =99914,PayMethod = "CC",PayQtdItems =1,PayPayDate = "01-04-01"},
             new Payment {PayOrder=20007,PayCustomer =99915,PayMethod = "DC",PayQtdItems =1,PayPayDate = "01-04-01"},
             new Payment {PayOrder=20008,PayCustomer =99921,PayMethod = "CC",PayQtdItems =1,PayPayDate = "01-04-01"},
             new Payment {PayOrder=20009,PayCustomer =00001,PayMethod = "CC",PayQtdItems =2,PayPayDate = "01-04-01"},
             new Payment {PayOrder=20010,PayCustomer =99921,PayMethod = "CC",PayQtdItems =3,PayPayDate = "01-04-01"},
             new Payment {PayOrder=20011,PayCustomer =99922,PayMethod = "CC",PayQtdItems =1,PayPayDate = "01-04-01"},
             new Payment {PayOrder=20012,PayCustomer =99923,PayMethod = "CC",PayQtdItems =1,PayPayDate = "01-04-01"},
             new Payment {PayOrder=20013,PayCustomer =99923,PayMethod = "CC",PayQtdItems =1,PayPayDate = "01-04-01"},
             new Payment {PayOrder=20014,PayCustomer =99924,PayMethod = "DC",PayQtdItems =1,PayPayDate = "01-04-01"},
             new Payment {PayOrder=20015,PayCustomer =99925,PayMethod = "CH",PayQtdItems =1,PayPayDate = "01-04-01"},
             new Payment {PayOrder=20016,PayCustomer =99925,PayMethod = "CH",PayQtdItems =2,PayPayDate = "01-04-01"}
        }.AsQueryable<Payment>();
    }
}
