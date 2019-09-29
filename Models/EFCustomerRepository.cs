using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cashier.Models
{
    public class EFCustomerRepository : ICustomerRepository
    {
        private static List<Customer> cStatic = new List<Customer>();

        private static List<Customer> cRepository = new List<Customer>()
        {

        };
        public IQueryable<Customer> Customers => new List<Customer> {
            new Customer
                      {
                          CustId = 00001,
                          CustEmail = "OWNER1@gmail.com",
                          CustFirstName = "Generic1",
                          CustLastName = "Generic1",
                          CustPhone = 1999999999
                      },
                      new Customer
                      {
                          CustId = 00002,
                          CustEmail = "OWNER2@gmail.com",
                          CustFirstName = "Generic2",
                          CustLastName = "Generic2",
                          CustPhone = 299999999
                      },
                      new Customer
                      {
                          CustId = 99913,
                          CustEmail = "amanda@gmail.com",
                          CustFirstName = "Amanda",
                          CustLastName = "Alvares",
                          CustPhone = 1234567890
                      },
                      new Customer
                      {
                          CustId = 99914,
                          CustEmail = "smaryann@gmail.com",
                          CustFirstName = "MaryAnn",
                          CustLastName = "Smith",
                          CustPhone = 1234567890
                      },
                      new Customer
                      {
                          CustId = 99915,
                          CustEmail = "pp@gmail.com",
                          CustFirstName = "Peter",
                          CustLastName = "Peterson",
                          CustPhone = 1234567890
                      },
                      new Customer
                      {
                          CustId = 99921,
                          CustEmail = "smithmichael@gmail.com",
                          CustFirstName = "Michael",
                          CustLastName = "Smith",
                          CustPhone = 1234567890
                      },
                      new Customer
                      {
                          CustId = 99922,
                          CustEmail = "irene_stark@gmail.com",
                          CustFirstName = "Irene",
                          CustLastName = "Stark",
                          CustPhone = 1234567890
                      },
                      new Customer
                      {
                          CustId = 99923,
                          CustEmail = "pedro9090@gmail.com",
                          CustFirstName = "Pedro",
                          CustLastName = "Alvares",
                          CustPhone = 1234567890
                      },
                      new Customer
                      {
                          CustId = 99924,
                          CustEmail = "mary-peterson@gmail.com",
                          CustFirstName = "Mary",
                          CustLastName = "Peterson",
                          CustPhone = 1234567890
                      },
                      new Customer
                      {
                          CustId = 99925,
                          CustEmail = "macfarllen@gmail.com",
                          CustFirstName = "Charlie",
                          CustLastName = "MacFarllen",
                          CustPhone = 1234567890
                      }
        }.AsQueryable<Customer>();
    }
}
