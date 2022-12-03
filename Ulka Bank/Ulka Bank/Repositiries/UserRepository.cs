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
        public UserRepository()
        {
           _bank = new Bank();

        }

        public void UserRegistration(User user)
        {
           
            Array.Resize(ref _bank.Users, _bank.Users.Length + 1);
            _bank.Users[_bank.Users.Length - 1] = user;
        }


        public bool UserLogin(string email, string password)
        {
            foreach (User item in _bank.Users)
            {
                if (item.Email == email && item.Password == password)
                {
                    item.IsLogged = true;
                    return true;
                }
            }
            return false;
        }

        public void FindUser(User user)
        {
           if (user !=null)
                foreach ( User user1 in _bank.Users )
                {
                    Console.WriteLine(user1);
                }
           else
            {
                Console.WriteLine("User not found\r\n");
            }
        }
      

    }
}
