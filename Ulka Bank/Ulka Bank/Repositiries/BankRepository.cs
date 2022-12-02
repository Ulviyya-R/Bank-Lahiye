using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ulka_Bank.Entities;

namespace Ulka_Bank.Repositiries
{
    internal class BankRepository : IBankRepository
    {
        public Bank Bank => throw new NotImplementedException();

        public void BankUserList()
        {
            throw new NotImplementedException();
        }

        public void BlockUser(User user)
        {
            throw new NotImplementedException();
        }

        public void ChangePassword(User user, string bankpassword)
        {
            throw new NotImplementedException();
        }

        public void CheckBalance(User user)
        {
            throw new NotImplementedException();
        }

        public void TopUpBalance(User user, double number)
        {
            throw new NotImplementedException();
        }
    }
}
