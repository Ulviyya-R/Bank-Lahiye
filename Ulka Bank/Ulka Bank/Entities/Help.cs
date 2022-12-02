using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulka_Bank.Entities
{
    internal static  class Help
    {
        public static bool CheckPassword(string passwor)
        {
            bool HasDigit = false;
            bool HasLower = false;
            bool HasUpper = false;
            bool result = false;
            char[] digits = { '0', '1', '3', '4', '5', '6', '7', '8', '9' };
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
                    break;
                }
            }
            return result;
        }

        public static bool CheckEmail(string email)
        {
            if (email.Contains("@"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
