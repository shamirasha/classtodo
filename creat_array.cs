using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assisment
{
    class creat_array
    {
        static void Main(string[] args)
        {
            array();
            Console.ReadKey();

        }
        public static void array()
        {
            const int size = 3;
            string[] basket = new string[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the item to be added to the basket");
                basket[i] = Console.ReadLine();
            }

            foreach (string item in basket)
                Console.WriteLine(item);
        }
    }
}
}
