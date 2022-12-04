using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulka_Bank.Entities
{
    internal static  class Help
    {

        #region CheckPassword Metod
        public static bool CheckPassword(string passwor)
        {
            bool HasDigit = false;
            bool HasLower = false;
            bool HasUpper = false;
            bool result = false;
            char[] digits = { '0', '1', '3', '4', '5', '6', '7', '8', '9' };
            if (passwor.Length>7)
            {
                foreach (char chars in passwor)
                {
                    foreach (var item in digits)
                    {
                        if (chars == item)
                        {
                            HasDigit = true;
                        }
                    }
                    if (char.IsDigit(chars))
                    {
                        HasDigit = true;
                    }
                    else if (char.IsLower(chars))
                    {
                        HasLower = true;
                    }
                    else if (char.IsUpper(chars))
                    {
                        HasUpper = true;
                    }
                    result = HasDigit && HasLower && HasUpper;
                    if (result)
                    {
                        return true;
                    }
                   
                }
                }
            return result;
        }
        #endregion

        #region CheckEmail Metod
        public static bool CheckEmail(string email)
        {
            if (email.Contains("@ulka.bank.az") == true)
            {
                return true;
            }
            else
            {
                Console.WriteLine("here should be @ulka.bank.az");
            }
            return false;
        }
        #endregion

        #region NameSurnameChecker Metod
        public static bool NameSurnameChecker(string name,string surname)
        {
            if(name.Length>2 && surname.Length>2)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Name and Surname must be 3 letters length");
            }
            return false;
        }
        #endregion
    }
}
