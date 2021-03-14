using AlifLesson16HW13._03.Models;
using System;

namespace AlifLesson16HW13._03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6 };
            Manipul manipulation = new Manipul();
            int[] numArray = manipulation.reverse(num);
            foreach (var item in numArray) Console.WriteLine(item);

            Console.WriteLine("---------------");

            string[] fruits = { "Apple", "Grape", "Rasberry", "Blackberry" };
            string[] fruitsArray = manipulation.countByAcending(fruits);
            foreach (var item in fruitsArray) Console.WriteLine(item);

            Console.WriteLine("---------------");

            int[] num2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };            
            foreach (var item in manipulation.sumAndCount(num2))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------");

            int[] num3 = { 1, 1, 1, 1, 2, 1, 1 };
            int[] num3Array = manipulation.uniqueNum(num3);
            foreach (var item in num3Array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
