using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Ulka_Bank.Entities;

namespace Ulka_Bank.Repositiries
{
    internal class UserRepository : IUserRepository
    {
        Bank _bank;       
        public Bank Bank  {get  =>  _bank; }    
        public UserRepository(Bank bank)
        {
           _bank = bank;

        }

        public void UserRegistration(User user)
        {
           
            Array.Resize(ref _bank.Users, _bank.Users.Length + 1);
            _bank.Users[_bank.Users.Length - 1] = user;
            Console.WriteLine("Your registration has been successfully completed");
            Thread.Sleep(2000);
        }


        public void UserLogin(User user)
        {
                  user.IsLogged = true;
                    Console.WriteLine("entry is successful!");
                    Console.WriteLine($"name: {user.Name} surname: {user.Surname}  " );
                    Thread.Sleep(2000);
                }


        public void FindUser(User user)
        {
            Console.WriteLine("User: " + user.Name + "Surname: " +user.Surname) ;
            Thread.Sleep(2000);
        }

       
    }
}
