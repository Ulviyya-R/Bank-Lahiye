﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ulka_Bank.Entities;

namespace Ulka_Bank.Repositiries
{
    internal class BankRepository : IBankRepository
    {
        Bank _bank;
        public Bank Bank { get => _bank; }

        public BankRepository()
        {
            _bank= new Bank();
        }

        public void CheckBalance(User user)
        {
            Console.WriteLine(user.Balance);
        }

        public void TopUpBalance(User user)
        {
            Console.WriteLine(user.Balance);
        }
        public string ChangePassword(User user, string newPas)
        {
            user.Password = newPas; ;
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
    }

}
