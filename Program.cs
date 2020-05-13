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


            System.Console.WriteLine("\n");
            int[] array = {1,2,3,4,5,6,7,8,9,10,-11,-12,-13,-14,-15};
            int[] resultArr = {array.Where(x => x > 0).Count(), array.Where(x => x < 0).Sum()};
            foreach(var v in resultArr)
            System.Console.WriteLine(v);
            

            System.Console.WriteLine();
            string[] s = {"Telescopes", "Glasses", "Eyes", "Monocles"};
            foreach(var ss in s.OrderBy(x => x.Length))
            System.Console.WriteLine(ss);
            

            System.Console.WriteLine();
            int[] numbers = {1,1,1,2,1,1};
            var snum = numbers.GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.Key);
            foreach(var x in snum)
            System.Console.WriteLine(x);
        }
    }
}
