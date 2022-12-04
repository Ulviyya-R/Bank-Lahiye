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

        void CheckBalance(double balance);

        void TopUpBalance(User user,double newBal);

        string ChangePassword(User user,string newPass);

        void BankUserList();

        bool BlockUser(User user);


        bool LogOut(User user);
        
    }
}
