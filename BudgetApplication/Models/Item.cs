using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApplication.Models
{
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ItemID { get; protected set; }
        public string CategoryID { get; protected set; }
        public string SubcategoryID { get; protected set; }
        public String Name { get; protected set; }
        public Double ExchangeRate { get; protected set; }
    }
}
