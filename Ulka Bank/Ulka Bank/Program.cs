using Ulka_Bank.Entities;
using Ulka_Bank.Service;

namespace Ulka_Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char selection;
            Console.WriteLine("Welcome our Bank");
            do
            {
                Console.WriteLine("1. User Registration");
                Console.WriteLine("2. User Login");
                Console.WriteLine("3. Find User");
                Console.WriteLine("0. Exit");
                selection:
                selection = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (selection)
                {
                    case '1':
                        MenuService.UserRegistration();
                        Console.Clear();
                        break;
                    case '2':
                        MenuService.UserLogin();
                        Console.Clear();
                        break;
                    case '3':
                        MenuService.FindUser();
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Please choose correct number");
                        Console.Clear();
                        goto selection;
                }
            } while (selection != '0');


        }
    }
    }
