using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Ulka_Bank.Entities;
using Ulka_Bank.Repositiries;

namespace Ulka_Bank.Service
{
    internal class UserService
    {
        readonly IUserRepository _repository;
        Bank bank;
        public UserService(Bank bank)
        {
            this.bank = bank;
            _repository = new UserRepository(this.bank);
        }

        #region UserRegistration
        public bool? UserRegistration(string name, string surname, string email, string password, bool isAdmin)
        {
            foreach (User gmail in _repository.Bank.Users)
            {
                if (gmail.Email == email)
                {
                    Console.WriteLine("This email had been registered ");
                    Thread.Sleep(2000);
                    Console.Clear();
                    MenuService.UserRegistration();
                    return false;
                }
            }
            User user = new User(name, surname, email, password, isAdmin);
            _repository.UserRegistration(user);
            return true;

        }
        #endregion


        #region UserLogin
        public bool UserLogin(string email, string password)
        {
            foreach (User item in _repository.Bank.Users)
            {
                if (item.Email == email && item.Password == password)
                {
                    _repository.UserLogin(item);

                    MenuService.BankOptions();
                    return true;
                   
                }

            }
                Console.WriteLine("--Email or password is incorrect...-- ");
            Thread.Sleep(2000);
           
        
            return false;
           
        }
        #endregion


        #region FindUser
        public bool FindUser(string email)
        {
            User exicted = default;
            foreach (User gmail in _repository.Bank.Users)
            {
                if (gmail.Email == email)
                {
                    exicted = gmail;
                    _repository.FindUser(exicted);
                    return false;
                }
            }
            if (exicted == null)
            {
                Console.WriteLine("--This email is not registered--");
                return false;
            }
                Console.WriteLine("Not Found");
            _repository.FindUser(exicted);
            return false;
        }
        #endregion

        #region EmailPassFind
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

        
        #endregion

    }
}
	

	
        
    

