using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulka_Bank.Entities
{
    internal class User
    {
        int _id;
        int _count;
        public string _name;
        public string _surname;
        public string _email;
        public string _password;
        public double Balance;
        public bool IsAdmin;
        public bool IsBlocked;
        public bool IsLogged;

       public User()
        {
            _count = 1000;
        }
        protected string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 3)
                {
                    _name = value;
                }
            }
        }
        protected string Surname
        {
            get

            {
                return _surname;
            }
            set
            {
                if (value.Length > 3)
                {
                    _surname = value;
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

        public User(string name, string surname, string email, string password, bool IsAdmin = false )
        {
            
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            _id = ++_count;
            IsAdmin = false;
            IsBlocked= false;
            IsLogged = false;

            
        }
       
       

}

}