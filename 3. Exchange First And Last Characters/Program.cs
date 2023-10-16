using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Exchange_First_And_Last_Characters
{
    internal class Program
    {
        static string ExchangeFirstAndLast(string input)
        {
            if (input.Length >= 2)
            {
                char[] chars = input.ToCharArray();
                char first = chars[0];
                chars[0] = chars[input.Length - 1];
                chars[input.Length - 1] = first;

                return new string(chars);
            }
            else
            {
                return input;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sample Input:");
            Console.Write("\"abcd\": ");
            string result1 = ExchangeFirstAndLast("abcd");
            Console.WriteLine(result1);

            Console.Write("\"a\": ");
            string result2 = ExchangeFirstAndLast("a");
            Console.WriteLine(result2);

            Console.Write("\"xy\": ");
            string result3 = ExchangeFirstAndLast("xy");
            Console.WriteLine(result3);
            Console.ReadLine();
        }
    }
}
