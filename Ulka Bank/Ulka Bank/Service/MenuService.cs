using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ulka_Bank.Entities;

namespace Ulka_Bank.Service
{
    internal class MenuService
    {
        readonly static UserService _uservice;
        readonly static BankService _bservice;
        static MenuService()
        {
            _uservice = new UserService();
            _bservice = new BankService();
        }

        #region UserService

        #region UserRegistration
        public static void UserRegistration()
        {
            string name;
            string surname;
            do
            {
                Console.WriteLine("Please enter your name: ");
                name = Console.ReadLine();
                Console.WriteLine("Please enter your surname: ");
                surname = Console.ReadLine();
            }
            while (!Help.NameSurnameChecker(name, surname));

            string email;
            do
            {
                Console.WriteLine("Please enter your email: ");
                email = Console.ReadLine();
            }
            while (!Help.CheckEmail(email));


            string passwrd;
            do
            {
                Console.WriteLine("Please enter your password: ");
                passwrd = Console.ReadLine();
            }
            while (!Help.CheckPassword(passwrd));



            char YesOrNoA;
            User admin;

            string Admin = null;
            bool IsAdmin = false;

            Console.WriteLine(" Are you Admin? yes Or No");
            Admin = Console.ReadLine();


            if (Admin == "y")
            {
                IsAdmin = true;
            }
            else if (Admin == "n")
            {
                IsAdmin = false;
            }
            _uservice.UserRegistration(name, surname, email, passwrd, IsAdmin);
        }

            #endregion

            #region UserLogin
            public static void UserLogin()
            {
                string email;
                string password;


                do
                {
                Console.WriteLine("Please add your email");
                    email = Console.ReadLine();
                Console.WriteLine("Please add your password");
                    password = Console.ReadLine();
                } while (!_uservice.UserLogin(email, password));

            }
            #endregion

            #region FindUser
            public static void FindUser()
            {
                string email;
                do
                {
                Console.WriteLine("Please add your email");
                    email = Console.ReadLine();
                } while (!_uservice.FindUser(email));
           
            }
            #endregion
            #endregion


            #region BankService
            #region CheckBalance
            public static void CheckBalance()
            {
                string password;
                do
                {
                    password = Console.ReadLine();
                } while (!_bservice.CheckBalance(password));
            }
            #endregion


            #region TopUpBalance
            public static void TopUpBalance()
            {
                string password;
                double newBal;
                do
                {
                    password = Console.ReadLine();
                    newBal = Convert.ToInt32(Console.ReadLine());
                } while (!_bservice.TopUpBalance(password, newBal));
            }
            #endregion

            #region ChangePassword
            public static void ChangePassword()
            {
                string password;
                string newPassw;

                do
                {
                    password = Console.ReadLine();
                    newPassw = Console.ReadLine();
                    Help.CheckPassword(newPassw);
                } while (!_bservice.ChangePassword(password, newPassw));
            }
            #endregion

            #region BankUserList
            public static void BankUserList()
            {
                string email;
                do
                {
                    Console.WriteLine("Enter your admin email");
                    email = Console.ReadLine();
                } while (!_bservice.BankUserList(email));
            }
            #endregion

            #region BlockUser
            public static void BlockUser()
            {
                BankUserList();
                string email;
                do
                {
                    Console.WriteLine("Enter the email address of the user you want to block");
                    email = Console.ReadLine();
                } while (!_bservice.BlockUser(email));
            }
            #endregion
            #endregion

        }
    }





 


             
            
