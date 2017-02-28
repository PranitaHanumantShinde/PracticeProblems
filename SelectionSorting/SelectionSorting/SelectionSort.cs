using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSorting
{
    class SelectionSort
    {
        public int[] Sort(int[] arr, int n)
        {
            int i, smallest, j, temp;
            for (i = 0; i < (n - 1); i++)
            {
                smallest = i;
                for (j = i + 1; j < n ; j++)
                {
                    if (arr[smallest] > arr[j])
                    {
                        smallest = j;
                    }
                }
                if (smallest != i)
                {
                    temp = arr[i];
                    arr[i] = arr[smallest];
                    arr[smallest] = temp;
                }
            }
            return arr;
        }

        public void Display(int[] arr,int n)
        {
            Console.WriteLine("Sorted array:");
            for(int i=0; i < n ; i++)
            {
                Console.WriteLine("{0}", arr[i]);
            }
        }
    }
}
