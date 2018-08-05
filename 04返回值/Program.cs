using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04返回值
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("请您确定是否关机？（y/n）");
            string s=ReadAnswer();
            //在Main方法中，我能知道用户输入的是y还是n吗？
            //被调用者如何访问方法中的变量
            if ( s=="y")      //根据方法中用户返回的值来确定是否执行
            {
                Console.WriteLine("正在关机……");
            }
            else
            {
                Console.WriteLine("取消关机！");
            }
            Console.ReadKey();
            */
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = Add(a, b);
            Console.WriteLine("平均值为：{0}",sum/2);
            Console.ReadKey();
        }
        public static int Add(int a, int b)
        {
            return a + b;
            //Console.WriteLine("a+b={0}", a + b);
        }
        //public static void ReadAnswer()
        public static string ReadAnswer()
        {
            string result = "";
            do
            {
                result = Console.ReadLine();
                if (result != "y" && result != "n")
                {
                    Console.WriteLine("输入有误，请重新输入！");
                }
                
            } while (result != "y" && result != "n");
            //当方法执行完成后，resul中存储的就是用户输入的y或n
            return result;
        }
    }
}
