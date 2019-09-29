using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cashier.Models
{
    public class EFItemRepository : IItemRepository
    {
        private static List<Item> pStatic = new List<Item>();

        private static List<Item> pRepository = new List<Item>()
        {

        };
        public IQueryable<Item> Payments => new List<Item> {
            new Item { ItemCode = 20001, ItemNumber = 1, ItemProduct =10001,ItemPrice = 1.99M  },
             new Item { ItemCode = 20001, ItemNumber = 2, ItemProduct =10001,ItemPrice = 1.99M  },
             new Item { ItemCode = 20002, ItemNumber = 1, ItemProduct =10002,ItemPrice = 172.00M},
             new Item { ItemCode = 20003, ItemNumber = 1, ItemProduct =10001,ItemPrice = 25.00M },
             new Item { ItemCode = 20004, ItemNumber = 1, ItemProduct =10004,ItemPrice = 5.99M  },
             new Item { ItemCode = 20005, ItemNumber = 1, ItemProduct =10003,ItemPrice = 3.99M  },
             new Item { ItemCode = 20006, ItemNumber = 1, ItemProduct =10001,ItemPrice = 1.99M  },
             new Item { ItemCode = 20007, ItemNumber = 1, ItemProduct =10004,ItemPrice = 5.99M  },
             new Item { ItemCode = 20008, ItemNumber = 1, ItemProduct =10001,ItemPrice = 171.00M},
             new Item { ItemCode = 20009, ItemNumber = 1, ItemProduct =10002,ItemPrice = 35.00M },
             new Item { ItemCode = 20009, ItemNumber = 2, ItemProduct =10001,ItemPrice = 25.00M },
             new Item { ItemCode = 20009, ItemNumber = 3, ItemProduct =10003,ItemPrice = 18.00M },
             new Item { ItemCode = 20010, ItemNumber = 1, ItemProduct =10003,ItemPrice = 3.99M  },
             new Item { ItemCode = 20011, ItemNumber = 1, ItemProduct =10001,ItemPrice = 171.00M},
             new Item { ItemCode = 20012, ItemNumber = 1, ItemProduct =10001,ItemPrice = 25.00M },
             new Item { ItemCode = 20013, ItemNumber = 2, ItemProduct =10004,ItemPrice = 10.99M },
             new Item { ItemCode = 20014, ItemNumber = 1, ItemProduct =10003,ItemPrice = 18.00M },
             new Item { ItemCode = 20014, ItemNumber = 2, ItemProduct =10004,ItemPrice = 10.99M },
             new Item { ItemCode = 20015, ItemNumber = 1, ItemProduct =10003,ItemPrice = 18.00M },
             new Item { ItemCode = 20015, ItemNumber = 2, ItemProduct =10004,ItemPrice = 10.99M },
             new Item { ItemCode = 20016, ItemNumber = 1, ItemProduct =10003,ItemPrice = 18.00M },
             new Item { ItemCode = 20016, ItemNumber = 2, ItemProduct =10004, ItemPrice = 10.99M}
        }.AsQueryable<Item>();
    }
}
