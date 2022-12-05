using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ulka_Bank.Entities;

namespace Ulka_Bank.Repositiries
{
    internal class BankRepository :IBankRepository
    {
        Bank _bank;
        public Bank Bank { get => _bank; }

        public BankRepository(Bank bank)
        {
            _bank=  bank;
        }

        public void CheckBalance(User user)
        {
           
            Console.WriteLine(user.Balance);
        }

        public void TopUpBalance(User user,double newBal)
        {
            user.Balance += newBal;
            Console.WriteLine("Successfully Added. New Balance: " + user.Balance);

        }
        public string ChangePassword(User user, string newPas)
        {
            user.Password = newPas; ;
            Console.WriteLine("New Password: ");
            return user.Password;
        }
        public void BankUserList()
        {
            foreach (User user in Bank.Users)
            {
                Console.WriteLine($"Name: {user.Name}  Surname:  {user.Surname}");
            }
        }

        public bool BlockUser(User user)
        {
           return  user.IsBlocked = true;
        }



        public bool LogOut(User user)
        {
            return user.IsLogged = false;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }

}
