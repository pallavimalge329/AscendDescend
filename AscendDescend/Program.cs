using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AscendDscend
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };

            // Sort array in ascending order.
            Array.Sort(arr);

            // reverse array
            Array.Reverse(arr);

            // print all element of array
            Console.Write("Array Element in Decending Order:\n ");

            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.Write("\n\n");



            Array.Reverse(arr);
            Console.Write("Array Element in Decending Order:\n ");
            // print all element of array
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.Read();
            Console.Read();
        }



    }
}
