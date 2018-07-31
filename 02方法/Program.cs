using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.ShowUI();   //调用者
            //Class1.MyTest();

            int score = 10;
            for (int i = 1; i < score; i++)
            {
                for (int j = 1; j < score; j++)
                {

                    Console.Write("{0}*{1}={2:00}  ", i, j, i * j);

                }
                Console.WriteLine();
            }
            ShowUI();
            Console.ReadKey();
        }
            public static void ShowUI()     //被调用者
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("------------------简 介------------------");
            Console.WriteLine("-----------------------------------------");
        }
        
        
    }
}
