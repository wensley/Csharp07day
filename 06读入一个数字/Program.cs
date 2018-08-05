using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06读入一个数字
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您的年龄：");
            int age = ReadInt();
            Console.WriteLine("您刚才输入的年龄是：{0}",age);

            Console.WriteLine("请输入您的出生年份：");
            int year = ReadInt();
            Console.WriteLine("您刚才输入的年份是：{0}" , year);

            Console.WriteLine("请输入您的班级人数：");
            int count = ReadInt();
            Console.WriteLine("您刚才输入的班级人数是：" + count);
            Console.ReadKey();

            //int[] number1 = {2,4 };
            //Test(number1[0],number1[1]);
        }
        //public static void Test(int number1,int number2)
        //{

        //}
        public static int ReadInt()
        {
            int number = 0;
            do
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    return number;      //返回number的值
                }
                catch
                {
                    Console.WriteLine("输入有误，请重新输入！");
                }
            } while (true);
        }
    }
}
