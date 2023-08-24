using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtodo
{
    class enum_for_week
    {
        enum weekday
        {
            monday,
            tuesday,
            wednesday,
            thrusday,
            friday,
            saturday,
            sunaday

        }
        static weekday selectweekday()
        {
            Console.WriteLine("enter a no(0-6) for a day in week");
            int daynumber = int.Parse(Console.ReadLine());
            if (Enum.IsDefined(typeof(weekday), daynumber))
            {
                return (weekday)daynumber;
            }
            else
            {
                Console.WriteLine("invalide input.defaulting to monday");
                return weekday.monday;
            }
        }

        static void Main(string[] args)
        {
            weekday selectedday = selectweekday();
            Console.WriteLine($"selectday:{selectedday}");
        }

    }
}
