using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number;
            Console.WriteLine("Enter no");
            Number = Convert.ToInt32(Console.ReadLine());
            CheckPalindrome c = new CheckPalindrome();
            c.CheckPal(Number);
            

        }
    }
}
