using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApplication.Models
{
    public class Category
    {
        public Guid CategoryID { get; protected set; }
        public String CategoryName { get; protected set; }

    }
}
