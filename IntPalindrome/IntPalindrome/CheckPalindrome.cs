using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntPalindrome
{
    class CheckPalindrome
    {
        int OrignalNo,remainder,r=0;
        public void CheckPal(int n)
        {
            OrignalNo = n;
            while(n!=0)
            {
                remainder = n % 10;
                r = r * 10 + remainder;
                n = n / 10;
            }
            if(OrignalNo==r)
            {
                Console.WriteLine("No is Plaindrome");
            
            }
            else
            {
                Console.WriteLine("No is not a Plaindrome");
            }
        }
    }
}
