using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlifLesson16HW13._03.Models
{
    class Manipul
    {
        public int[] reverse(int[] arr) { return arr.Reverse().ToArray(); }

        public string[] countByAcending(string[] arr) { return arr.OrderBy(t => t.Length).ToArray(); }

        public int[] sumAndCount(int[] arr) 
        {
            int sum = arr.Where(t => t < 0).Sum();
            int count = arr.Where(t => t > 0).Count();
            int[] array = { count, sum };
            return array;
        }

        public int[] uniqueNum(int[] arr)
        {
            return (arr.GroupBy(i => i).Where(i => i.Count() == 1).Select(i => i.Key)).ToArray();
        }        
    }
}
