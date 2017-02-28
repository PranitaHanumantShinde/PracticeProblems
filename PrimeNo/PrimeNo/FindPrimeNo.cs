using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNo
{
    class FindPrimeNo
    {
        public bool GetPrime(int n)
        {
            int count=0;
            for(int i=2 ; i<n ; i++)
            {
                if(n%i==0)
                {
                    count++;
                }
                if(count==1)
                {
                    return false;
                }
                
            }
            return true;
        }
    }
}
