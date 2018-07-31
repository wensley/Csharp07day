using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01复习及作业
{
    class Program
    {
        static void Main(string[] args)
        {
            // 32复习作业讲解
            /*
            //练习1：从一个整数数组中取出最大的整数
            int[] number = {12,34,56,52,99,47,86,19};
            int max = 0;
            //对数组中元素进行赋值
           for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > max)
                {
                    max =number[i];
                }
            }
            Console.WriteLine("您输入的整数中最大的为：{0}",max);
            
            */
            /*
            //练习2 计算一个整数数组的所有元素的和
            int sum = 0;
            int[] number = {12,34,56,52,99,47,86,19};
            for(int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            //for (int i = 0; i < number.Length; i++)
            //{
            //    sum += number[i];
            //}
            Console.WriteLine("整数数组的所有元素的和为：{0}",sum);
            */
            /*
            //练习3：将一个字符串数组输出为|分割的形式，比如”梅西|卡卡|郑大世“
            // 1
            string[] name = { "梅西", "卡卡", "郑大世" };
            for (int i = 0; i < name.Length; i++)
            {
                //Console.WriteLine("请输入第{0}个球员名字",i+1);
                //name[i] = Console.ReadLine();
                
                Console.WriteLine("{0}|{1}|{2}", name[0], name[1], name[2]);
                break;
            }
            
            // 2 标准
            string[] names = { "梅西", "卡卡", "郑大世" };
            string str = "";
            for (int i = 0; i < names.Length; i++)
            {
                if (i == names.Length - 1)
                {
                    str = str + names[i];
                }
                else
                {
                    str = str + names[i] + "|";
                }
            }
            Console.WriteLine(str);
            */

            //练习4：将一个整数数组的每一个元素进行如下的处理：如果元素是正数则将这个位置的元素的值加1，如果元素是负数则将这个位置的元素的值减1，如果元素是0，则不变。
            /*
            int[] number = {12,34,-56,52,-99,0,-86,19};
            int num = 0;
            
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > 0)
                {
                    num=number[i] + 1;
                    Console.WriteLine(num);
                }
                if (number[i] < 0)
                {
                    num=number[i] - 1;
                    Console.WriteLine(num);
                }
                if (number[i] == 0)
                {
                    num=number[i] + 0;
                    Console.WriteLine(num);
                }
               
            }
            
             */
            //练习5：将一个字符串数组的元素的顺序进行反转。
            /*
            string[] names = { "梅西", "卡卡", "郑大世", "张三", "李四" };
            string temp;  //借助之前学习的temp来交换
            for (int i = 0; i < names.Length/2;i++)
            {
                //交换第i个元素与第Length-1-i个
                //交换第names[i]个元素与第names.Length-1-i个
                temp = names[i];
                names[i] = names[names.Length - 1 - i];
                names[names.Length - 1 - i] = temp;
            }
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            */
            
            //冒泡排序
            int[] score = {18,20,48,76,20,38,87,90,37,45,65,65,34,67,95 };
            for (int i = 0; i < score.Length-1; i++)    //控制比较的遍数，循环一次表示比较了一遍
            {
                for(int j = 0; j < score.Length - 1 - i; j++)   //每循环一次，比较的元素-1
                {
                    if (score[j] < score[j + 1])    //控制输出的排序
                    {
                        int temp = score[j];
                        score[j] = score[j + 1];
                        score[j + 1] = temp;
                    }
                    
                }
            }
            for (int i = 0; i < score.Length; i++)
            {
                Console.WriteLine(score[i]);
            }
            /* 重写99乘法表输出
             int score = 10;
             for (int i = 1; i < score; i++)
             {
                 for (int j = 1; j < score; j++)
                 {

                         Console.Write("{0}*{1}={2:00}  ",i,j,i*j);

                 }
                 Console.WriteLine();
             }
              */
            Console.ReadKey();
        }
    }
}
