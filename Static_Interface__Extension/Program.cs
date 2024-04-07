using Static_Interface__Extension.Extension;
using Static_Interface__Extension.Moduls;
using System.Threading.Channels;

namespace Static_Interface__Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            string text = "Password123";

            Console.WriteLine($"{num1} is odd: {num1.IsOdd()}");
            Console.WriteLine($"{num2} is even: {num2.IsEven()}");
            Console.WriteLine($"Does \"{text}\" have a digit: {text.HasDigit()}");
            Console.WriteLine($"Is \"{text}\" a valid password: {text.CheckPassword()}");
            Console.WriteLine($"Capitalized version of \"{text}\": {text.Capitalize()}");
        }
    }
}
