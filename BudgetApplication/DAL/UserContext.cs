using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using BudgetApplication.Models;

namespace BudgetApplication.Data
{
    public class UserContext : DbContext
    {
        protected UserContext() : base("connection string")
        {
        }
        public DbSet<User> Usersdb { get; protected set; }
    }
}
