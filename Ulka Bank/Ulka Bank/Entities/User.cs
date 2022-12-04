using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulka_Bank.Entities
{
    internal class User
    {
         public int id;
        int _count;
        string _name;
        string _surname;
        string _email;
        string _password;
        double _balance;
        public bool IsAdmin;
        public bool IsBlocked;
        public bool IsLogged;

       public User()
        {
            _count = 0;
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (Help.NameSurnameChecker(value,value))
                {
                    _name = value;
                }
            }
        }
        public string Surname
        {
            get

            {
                return _surname;
            }
            set
            {
                if (Help.NameSurnameChecker(value,value))
                {
                    _surname = value;
                }
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
               if (Help.CheckEmail(value)) 
                {
                    _email = value;
                }
            }
    }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (Help.CheckPassword(value))
                {
                    _password = value;
                }
            }
        }
        
        public double Balance {
            
            get 
            { 
                return _balance;
            
            }
            set
            {
                _balance = value;
            }
           

        }

        public User(string name, string surname, string email, string password, bool IsAdmin = false )
        {
            
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            id = ++_count;
            Balance = default;
            IsAdmin = false;
            IsBlocked= false;
            IsLogged = false;

            
        }
        public User(string email)
        {
            Email = email;
        }
       
       

}

}