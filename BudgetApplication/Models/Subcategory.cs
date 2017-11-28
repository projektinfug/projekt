using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApplication.Models
{
    public class Subcategory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string SubcategoryID { get; protected set; }
        public String SubcategoryName { get; protected set; }
        public string CategoryID { get; protected set; }
    }
}
