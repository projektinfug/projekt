using System;
using System.Collections.Generic;
using BudgetApplication.Models;

namespace BudgetApplication.DAL
{
    public class UserRepository : IUserRepository, IDisposable, IEquatable<UserRepository>
    {
        

        public void DeleteUser(string userID)
        {
            //var User = from usr in Users
        }

        public User GetUserByID(string userId)
        {
            //var User = from usr in  where usr.UserID == userId
            //           select usr;
            // return User;
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void InsertUsert(User user)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls
        private object Userdb;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UserRepository() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as UserRepository);
        }

        public bool Equals(UserRepository other)
        {
            return other != null &&
                   disposedValue == other.disposedValue;
        }

        public override int GetHashCode()
        {
            return 14850879 + disposedValue.GetHashCode();
        }
        #endregion
    }
}
