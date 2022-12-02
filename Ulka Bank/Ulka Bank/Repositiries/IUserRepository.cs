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
        void UserRegistration(string name, string surname, string email, string password, bool isAdmin);

        bool UserLogin(string email, string password);

        void FindUser(User user);

    }
}
