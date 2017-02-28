using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Enter a String");
            s = Console.ReadLine();
            CheckPalindrome c = new CheckPalindrome();
            c.CheckPal(s);
            
        }
    }
}
