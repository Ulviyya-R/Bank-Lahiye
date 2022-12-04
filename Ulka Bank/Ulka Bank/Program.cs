using System.Security.Cryptography.X509Certificates;
using Ulka_Bank.Entities;
using Ulka_Bank.Service;

namespace Ulka_Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        
        }
    }





    

