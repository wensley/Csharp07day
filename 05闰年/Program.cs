using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05闰年
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine());
            bool result = LeapYear(year);
            if (result)
            {
                Console.WriteLine("闰年");
            }
            else
            {
                Console.WriteLine("不是闰年");
            }
            Console.ReadKey();
        }

            public static bool LeapYear(int year)
        {
            if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
