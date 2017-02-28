using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNo
{
    class Program
    {
        static void Main(string[] args)
        {
            int No;
            Console.WriteLine("Enter no:");
            No = Convert.ToInt32(Console.ReadLine());
            FindPrimeNo Prime = new FindPrimeNo();
            if(Prime.GetPrime(No))
            {
                Console.WriteLine("No is Prime no");
            }
            else
            {
                Console.WriteLine("No is Not a Prime no");
            }
        }
    }
}
