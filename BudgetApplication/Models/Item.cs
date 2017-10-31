using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApplication.Models
{
    public class Item
    {
        public Guid ItemID { get; protected set; }
        public int CategoryID { get; protected set; }
        public int SubcategoryID { get; protected set; }
        public String Name { get; protected set; }
        public Double ExchangeRate { get; protected set; }
    }
}
