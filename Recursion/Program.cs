using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "shwetaketu";
            char[] arr;

            arr = str.ToCharArray(0, 10);
            Console.Write("The letters in '{0}' are: '", str);
            Console.Write(arr);
            Console.WriteLine("'");
            Console.WriteLine("Each letter in '{0}' is:", str);
            foreach (char c in arr)
            Console.WriteLine(c);


            string s2 = GetRev(arr);
            Console.WriteLine("The letters in {0} written in reversed are {1}", str, s2);
            Console.Read();


        }

        static string GetRev(char[] s)
        {
            string reversed = "";
            string input = new string (s);
            //Console.WriteLine(s);
            for (int count = input.Length-1; count >= 0; --count)
            {
                reversed += input[count];
            }

            return reversed;

        }

        static void GenLength(char s) 
        {
 
        }
    }
}
