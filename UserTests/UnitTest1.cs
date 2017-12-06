using System;
using Xunit;
using BudgetApplication.Models;
namespace UserTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            User user = new User();
            Assert.Null(user.Username);
        }
    }
}
