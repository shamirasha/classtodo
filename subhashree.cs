using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtodo
{
    class program
    {
        public void displaymessage()
        {
            Console.WriteLine("this is a message from subhashree");
        }
    }  
    class subhashree
    {
        static void Main(string[] args)
        {
            program a = new program();
            a.displaymessage();
        }
    }
}
