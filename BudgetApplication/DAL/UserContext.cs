
using BudgetApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgetApplication.Data
{
    public class UserContext : DbContext
    {
        protected UserContext() 
        {
        }
        public DbSet<User> Usersdb { get; protected set; }
    }
}
