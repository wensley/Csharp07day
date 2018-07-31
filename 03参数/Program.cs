using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03参数
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "nokia";
            int a = 3;
            //int xs = int.Parse(s);    把字符串转换为所在的数字类型；
            Test(a);        //调用者
            //Console.WriteLine(a);
            Console.WriteLine(s);
            Add(10, 20);

        }
        public static void Test(int number)     //形参    被调用者
        {
            //a=a+5;
            Console.WriteLine(number);
            Console.ReadKey();
        }
        public static void Add(int a,int b)
        {
            Console.WriteLine("a+b={0}",a+b);
            Console.ReadKey();
        }
    }
}
