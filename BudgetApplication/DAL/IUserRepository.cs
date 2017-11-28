using BudgetApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApplication.DAL
{
    interface IUserRepository : IDisposable
    {
        IEnumerable<User> GetUsers();
        User GetUserByID(string userId);
        void InsertUsert(User user);
        void DeleteUser(string userID);
        void UpdateUser(User user);
        void Save();
    }
}
