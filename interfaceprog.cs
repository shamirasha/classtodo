using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtodo
{
    class interfaceprog
    {
        static void Main(string[] args)
        {
            myinterface interfaceinst = new interfaceimplementation();
            interfaceinst.methodinterface();
        }
        interface myinterface
        {
            void methodinterface();
        }
        class interfaceimplementation : myinterface
        {
            public void methodinterface()
            {
                Console.WriteLine("method implemented frm myinterface:");
            }
        }
    }
}
