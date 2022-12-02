using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ulka_Bank.Entities;
using Ulka_Bank.Repositiries;

namespace Ulka_Bank.Service
{
    internal class UserService
    {
        readonly IUserRepository _repository;
        public UserService()
        {
            _repository = new UserRepository();
        }

       public bool? UserRegistration(string name, string surname, string email, string password, bool isAdmin)
        {
            foreach (User gmail in _repository.Bank.Users)
            {
                if (gmail.Email == email)
                {
                    return false;
                }
            }
            User user = new User(name, surname, email, password, isAdmin);
            return true;

        }

        public bool FindUser(string email, string password)
       {
               User exicted = default;
             foreach (User gmail in _repository.Bank.Users)
            {
                if (gmail.Email == email)
                {
                    exicted = gmail;
                }
            }
             if (exicted == null) 
            {
                return false;
            }
            _repository.FindUser(exicted);
            return true;
           }

        bool EmailPassFind(string email, string password) 
        {
          foreach (User user in _repository.Bank.Users)
            {
                if (user.Email == email && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        public bool UserLogin (string email,string password)
        {
              EmailPassFind(email, password);
            if (EmailPassFind(email,password) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
            _repository.UserLogin(email, password);
            return true;
        }

}
}
	

	
        
    

