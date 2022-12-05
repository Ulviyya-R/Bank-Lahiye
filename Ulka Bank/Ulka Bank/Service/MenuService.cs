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
        static Bank ourBank;
        static MenuService()
        {
            ourBank = new Bank();
            _uservice = new UserService(ourBank);
            _bservice = new BankService(ourBank);
        }

        #region UserService

        #region UserRegistration
        public static void UserRegistration()
        {
            string name;
            string surname;
            do
            {
                Console.WriteLine("User Registration \r\n");
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
        public static bool UserLogin()
        {
            string email;
            string password;
            Console.WriteLine("Access To The Bank \r\n");
            Console.WriteLine("Please enter your  email: ");
            email = Console.ReadLine();
            Console.WriteLine("Please enter your password: ");
            password = Console.ReadLine();
            if (_uservice.UserLogin(email, password))
            {
                return false;
            }
            return false;
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
            } while (_uservice.FindUser(email));

        }
        #endregion
        #endregion


        #region BankService
        #region CheckBalance
        public static void CheckBalance()
        {
            string password;
            Console.WriteLine("Check Balance:\r\n ");
            Console.WriteLine("Please enter your password:  ");
            password = Console.ReadLine();
            Console.WriteLine("    Balance:      ");
            if (_bservice.CheckBalance(password))
            {
                Console.WriteLine("Returns to the Bank Menu...");
                Thread.Sleep(5000);

            }

        }
        #endregion


        #region TopUpBalance
        public static void TopUpBalance()
        {
            string password;
            double newBalance;
            Console.WriteLine("Top Up Balance\r\n");
            Console.WriteLine("Please enter  password: ");
            password = Console.ReadLine();
            Console.WriteLine("Write the amount you will pay: ");
            newBalance = Convert.ToDouble(Console.ReadLine());
            if (_bservice.TopUpBalance(password, newBalance))
            {
                Console.WriteLine("Returns to the Bank Menu...");
                Thread.Sleep(5000);
            }
        }
        #endregion

        #region ChangePassword
        public static void ChangePassword()
        {
            string password;
            string newPassw;

            Console.WriteLine("Change Password\r\n");
            do
            {
                Console.WriteLine("Please enter  Current Password: ");
                password = Console.ReadLine();
                Console.WriteLine("Please your New Password");
                newPassw = Console.ReadLine();
                Help.CheckPassword(newPassw);
            } while (!_bservice.ChangePassword(password, newPassw));
        }
        #endregion

        #region BankUserList
        public static void BankUserList()
        {
            Console.WriteLine("Users \r\n");
            string email;
            Console.WriteLine("Please enter Admin's email: ");
            email = Console.ReadLine();
            if (_bservice.BankUserList(email))
            {
                Console.WriteLine("Returns to the Bank Menu...");
                Thread.Sleep(5000);
            }
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

        #region LogOut
        public static void LogOut()
        {
            MenuService.UserOptions();
        }
        #endregion
        #endregion

        #region User and Bank Program Metods
        public static void BankOptions()
        {



            char BankServiceSelection;
            Console.ForegroundColor = ConsoleColor.Gray;

            do
            {
                Console.WriteLine("1. Check balance");
                Console.WriteLine("2. Top up balance");
                Console.WriteLine("3. Change password");
                Console.WriteLine("4. Bank user list");
                Console.WriteLine("5. Block user");
                Console.WriteLine("6. Logout");
            selection1:
                BankServiceSelection = Console.ReadKey().KeyChar;
                Console.Clear();
                Console.WriteLine();
                switch (BankServiceSelection)
                {
                    case '1':
                        MenuService.CheckBalance();
                        Console.Clear();
                        break;
                    case '2':
                        MenuService.TopUpBalance();
                        Console.Clear();
                        break;
                    case '3':
                        MenuService.ChangePassword();
                        Console.Clear();
                        break;
                    case '4':
                        MenuService.BankUserList();
                        Console.Clear();
                        break;
                    case '5':
                        MenuService.BlockUser();
                        Console.Clear();
                        break;
                    case '6':
                        MenuService.LogOut();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Please choose correct number");
                        Console.Clear();
                        goto selection1;
                }
            } while (BankServiceSelection != '0');
        }

        public static void UserOptions()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome Ulka Bank");
            char UserServiceSelection;
            Console.ForegroundColor = ConsoleColor.Cyan;
            do
            {
                Console.WriteLine("1. Registration");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Find User");
                Console.WriteLine("0. Exit");
            selection:
                UserServiceSelection = Console.ReadKey().KeyChar;
                Console.Clear();
                Console.WriteLine();
                switch (UserServiceSelection)
                {
                    case '1':
                        MenuService.UserRegistration();
                        Console.Clear();
                        break;
                    case '2':
                        MenuService.UserLogin();

                        break;
                    case '3':
                        MenuService.FindUser();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Please choose correct number");
                        Console.Clear();
                        goto selection;
                }
            } while (UserServiceSelection != '0');
        }
        #endregion
    }
}














            