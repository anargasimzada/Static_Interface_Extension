using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Interface__Extension.Moduls
{
    internal static class Helper
    {
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }

        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
        public static bool HDigit(this string str)
        {
            return str.Any(char.IsDigit);
        }

        public static bool CheckPassword(this string password)
        {
            return password.Any(char.IsUpper) &&
                   password.Any(char.IsLower) &&
                   password.Any(char.IsDigit) &&
                   password.Length >= 8;
        }

    }
}
