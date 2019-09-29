using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cashier.Models
{
    public class EFProductRepository : IProductRepository
    {
        private static List<Product> pStatic = new List<Product>();

        private static List<Product> pRepository = new List<Product>()
        {

        };
        public static IEnumerable<Product> PRepository
        {
            get
            {
                return pRepository;
            }
        }

        public IQueryable<Product> Products => new List<Product> {
            new Product
            {
                ProdCode = 10001,
                ProdCategory = "FOOD0001",
                ProdShort = "BURGUER",
                ProdLong = "Burguer with fries",
                ProdRetail = 15,
                ProdCost = 10,
                ProdDiscount = 0,
                ProdStock = 120,
                ProdSupplier = "OWNER"
            },
            new Product
            {
                ProdCode = 10002,
                ProdCategory = "FOOD0002",
                ProdShort = "PIZZA",
                ProdLong = "Frozen Pizza",
                ProdRetail = 17,
                ProdCost = 9,
                ProdDiscount = 2,
                ProdStock = 15,
                ProdSupplier = "PizzaPizza"
            },
            new Product
            {
                ProdCode = 10003,
                ProdCategory = "FOOD0003",
                ProdShort = "CAKE",
                ProdLong = "Slice of Cake",
                ProdRetail = 6,
                ProdCost = 2,
                ProdDiscount = 0,
                ProdStock = 9,
                ProdSupplier = "OWNER"
            },
            new Product
            {
                ProdCode = 10004,
                ProdCategory = "FOOD0004",
                ProdShort = "CHOCOLATE",
                ProdLong = "Dark Nestle",
                ProdRetail = 4.5M,
                ProdCost = 1.5M,
                ProdDiscount = 0,
                ProdStock = 98,
                ProdSupplier = "NESTLE"
            },
            new Product
            {
                ProdCode = 10005,
                ProdCategory = "DRNK0001",
                ProdShort = "WATER",
                ProdLong = "Water",
                ProdRetail = 3,
                ProdCost = 0.99M,
                ProdDiscount = 0,
                ProdStock = 450,
                ProdSupplier = "ONTARIO"
            },
            new Product
            {
                ProdCode = 10006,
                ProdCategory = "DRNK0002",
                ProdShort = "COLA",
                ProdLong = "Cola",
                ProdRetail = 1.69M,
                ProdCost = 0.56M,
                ProdDiscount = 0,
                ProdStock = 237,
                ProdSupplier = "COCA-COLA"
            },
            new Product
            {
                ProdCode = 10007,
                ProdCategory = "DRNK0003",
                ProdShort = "COFFE",
                ProdLong = "Cup of Coffe",
                ProdRetail = 2,
                ProdCost = 0.98M,
                ProdDiscount = 0,
                ProdStock = 89,
                ProdSupplier = "OWNER"
            },
            new Product
            {
                ProdCode = 10008,
                ProdCategory = "DRNK0004",
                ProdShort = "MILK",
                ProdLong = "Milk",
                ProdRetail = 7.56M,
                ProdCost = 5.60M,
                ProdDiscount = 0,
                ProdStock = 9,
                ProdSupplier = "FARMER"
            },
            new Product
            {
                ProdCode = 10009,
                ProdCategory = "SVNR0001",
                ProdShort = "BOOK",
                ProdLong = "Book from Toronto",
                ProdRetail = 90,
                ProdCost = 75,
                ProdDiscount = 5,
                ProdStock = 5,
                ProdSupplier = "MKT"
            },
            new Product
            {
                ProdCode = 10010,
                ProdCategory = "SVNR0002",
                ProdShort = "KEYHOLDER",
                ProdLong = "Keyholder CNTower",
                ProdRetail = 25,
                ProdCost = 15,
                ProdDiscount = 2.5M,
                ProdStock = 29,
                ProdSupplier = "MKT"
            },
            new Product
            {
                ProdCode = 10011,
                ProdCategory = "SVNR0003",
                ProdShort = "MOUSEPAD",
                ProdLong = "MousePad Vancouver",
                ProdRetail = 35,
                ProdCost = 26,
                ProdDiscount = 0,
                ProdStock = 59,
                ProdSupplier = "MKT"
            },
            new Product
            {
                ProdCode = 10012,
                ProdCategory = "SVNR0004",
                ProdShort = "BAG",
                ProdLong = "Recycle Bag",
                ProdRetail = 3,
                ProdCost = 1.34M,
                ProdDiscount = 0,
                ProdStock = 19,
                ProdSupplier = "MKT"
            }

        }.AsQueryable<Product>();
    }
}
