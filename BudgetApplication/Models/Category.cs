using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApplication.Models
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string CategoryID { get; protected set; }
        public String CategoryName { get; protected set; }
        public string UserID { get; protected set; }

    }
}
