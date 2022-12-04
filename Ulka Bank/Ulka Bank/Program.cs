using System.Security.Cryptography.X509Certificates;
using Ulka_Bank.Entities;
using Ulka_Bank.Service;

namespace Ulka_Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char selection;
            Console.WriteLine("Welcome Our Bank");
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
                        Thread.Sleep(500);
                        Console.Clear();

                        break;
                    case '2':
                        MenuService.UserLogin();
                        Bank();
                        Thread.Sleep(500);
                        Console.Clear();

                        break;
                    case '3':
                        MenuService.FindUser();
                        Thread.Sleep(500);
                        Console.Clear();

                        break;
                    default:
                        Console.WriteLine("Please choose correct number");
                        Console.Clear();
                        goto selection;
                }
            } while (selection != '0');



        }

        public static void Bank()
            {

                char selection1;
                Console.WriteLine("");
                do
                {
                    Console.WriteLine("8. Check Balance");
                    Console.WriteLine("9. Top Up Balance");
                    Console.WriteLine("7. Change Password");
                    Console.WriteLine("4. Bank User List");
                    Console.WriteLine("5. Block User");
                    Console.WriteLine("6. Log Out ");
                selection1:
                    selection1 = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    switch (selection1)
                    {
                        case '8':
                            MenuService.CheckBalance();
                            Thread.Sleep(500);
                            Console.Clear();

                            break;
                        case '9':
                            MenuService.TopUpBalance();
                            Thread.Sleep(500);
                            Console.Clear();
                            break;
                        case '7':
                            MenuService.ChangePassword();
                            Thread.Sleep(500);
                            Console.Clear();

                            break;
                        case '4':
                            MenuService.BankUserList();
                            Thread.Sleep(500);
                            Console.Clear();
                            break;

                        case '5':
                            MenuService.BlockUser();
                            Thread.Sleep(500);
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Please choose correct number");
                            Console.Clear();
                            goto selection1;
                    }
                } while (selection1 != '0');
            }



        }
    }


    

