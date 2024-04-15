using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEPEG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reverseString = Console.ReadLine();
            if (IsPalidrome(reverseString))
            {
                Console.WriteLine("Je palidrom");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Neni palidrom");
                Console.ReadKey();
            }
        }
        static bool IsPalidrome(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
