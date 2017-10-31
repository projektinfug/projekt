using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApplication.Models
{
    public class Transaction
    {
        public Guid TransactionID { get; protected set; }
        public int ItemID { get; protected set; }
        public int CategoryID { get; protected set; }
        public int SubcategoryID { get; protected set; }
        public Double Price { get; set; }
        public DateTime TransactionDate { get; protected set; } = DateTime.UtcNow;
        public String TransactionPlace { get; protected set; }
        public Double? ExchangeRate { get; protected set; }
    }
}
