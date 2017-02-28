using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPalindrome
{
    class Program
    {
        int num1;

        static void Main(string[] args)
        {
            int i, j, length;
            string s;
            StringBuilder str = new StringBuilder();
            Console.WriteLine("Enter a string");
            s = Console.ReadLine();
            length = s.Length;
            char[] arr = s.ToCharArray();
            Program p = new Program();
            Stack<char> char1 = new Stack<char>();
            foreach (char c in arr)
                char1.Push(c);

            Console.WriteLine(char1.Count());

            while (char1.Count != 0)
            {
                str.Append(char1.Pop());
               // Console.Write(char1.Pop());
            }
            if(str.ToString()==s)
            {
                Console.WriteLine("palin");
            }
            else
            {
                Console.WriteLine("Not palin");
            }
        }
    }
}
