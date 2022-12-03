using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ulka_Bank.Entities;

namespace Ulka_Bank.Repositiries
{
    internal interface IUserRepository
    {
        public Bank Bank { get; }
        void UserRegistration(User user);

        bool UserLogin(string email, string password);

        void FindUser(User user);

    }
}
