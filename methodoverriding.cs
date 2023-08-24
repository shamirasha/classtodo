using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtodo
{
    class Base
        {
            public virtual void showmessage()
        {
            Console.WriteLine("message from base class");
        }

        }
    class derive : Base
    {
        public override void showmessage()
        {
            Console.WriteLine("message from derived class");
        }
    }
    class methodoverriding
    {
        static void Main(string[] args)
        {
            derive deriveinst = new derive();
            deriveinst.showmessage();
        }
    }
}
