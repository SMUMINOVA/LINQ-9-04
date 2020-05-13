using System.Linq;
using System;
using System.Collections.Generic;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 123456789;
            int[] an = new int[9];
            int i = 0;
            System.Console.WriteLine(n);
            while(n > 0){
                an[i] = n%10;
                n /= 10;
                System.Console.Write(an[i] + " ");
                i++;
            }
            System.Console.WriteLine();
            foreach(var m in an.Reverse())
            System.Console.Write(m + " ");

            int[] array = {1,2,3,4,5,6,7,8,9,10,-11,-12,-13,-14,-15};
            int[] resultArr = {array.Where(x => x > 0).Count(), array.Where(x => x < 0).Sum()};
            foreach(var v in resultArr)
            System.Console.WriteLine(v);
        }
    }
}
