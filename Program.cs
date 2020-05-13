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

        }
    }
}
