using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ulka_Bank.Entities;

namespace Ulka_Bank.Repositiries
{
    internal interface IBankRepository
    {
        public Bank Bank { get; }

        void CheckBalance(User user);

        void TopUpBalance(User user,double number);

        void ChangePassword(User user,string bankpassword);

        void BankUserList();

        void BlockUser(User user);


    }
}
