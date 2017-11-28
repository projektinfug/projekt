using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApplication.Models
{
    public class Transaction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string TransactionID { get; protected set; }
        public string ItemID { get; protected set; }
        public string CategoryID { get; protected set; }
        public string SubcategoryID { get; protected set; }
        public Double Price { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime TransactionDate { get; protected set; } = DateTime.UtcNow;
        public String TransactionPlace { get; protected set; }
        public Double? ExchangeRate { get; protected set; }
    }
}
