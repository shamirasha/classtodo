using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtodo
{
    class reverse_array
    {
        static void Main(string[] args)
        {
            int[] originalarray = { 1, 2, 3, 4, 5 };
            int[] reversearrays = reversearray(originalarray);
            Console.WriteLine("reversed array:");
            foreach(int num in reversearrays)
            {
                Console.WriteLine(num+" ");
            }
            Console.ReadLine();
        }
        static int[] reversearray(int[] array)
        {
            int[] reversearray = new int[array.Length];
            for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
            {
                reversearray[i] = array[j];
            }
            return reversearray;
        }
    }
}
