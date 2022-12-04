using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ulka_Bank.Entities
{
    internal class Bank
    {
        public int id;
        public User[] Users=new User[0];
        static int count;

        public Bank()
        {
            id = ++count;
        }

        static Bank()
        {
            count = 400;
        }
    }
}
