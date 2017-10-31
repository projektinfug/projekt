using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApplication.Models
{
    public class User
    {
        public String Username { get; protected set; }
        public String Email { get; protected set; }
        public String Password { get; protected set; }
        public int Age { get; set; }
    }
}
