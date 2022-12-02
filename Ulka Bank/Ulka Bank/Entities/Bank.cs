using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulka_Bank.Entities
{
    internal class Bank
    {
        int _id;
        public User[] Users;
        public static int count;

        public Bank(int id, string name, string surname)
        {
            Users = new User[0];

            
                }

        public Bank()
        {
        }
    }
        }
    
