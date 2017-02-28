using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrPalindrome
{
    class CheckPalindrome
    {
        public void CheckPal(string s)
        {
            int length, i, j, count = 0;
            length = s.Length;
            char[] arr = s.ToCharArray();
            for (i = 0, j = length; i <= j; i++, j--)
            {
                if (arr[i] == arr[j-1])
                {
                    count++;
                }
            }
            if (count == (length / 2 +1))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}
