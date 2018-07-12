using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] v4 = new int[]
            {
                4,44,444
            };
            int sum = 0;

            //for (int i = 0; i < v4.Length; i++)
            //{
            //    Console.WriteLine(v4[i]);
            //}

            for (int i = 1; i <= 1000; i++)
            {
                if (v4[0] == i || v4[1] == i || v4[2] == i)
                    continue;
                sum += i;
                Console.WriteLine("i={0},sum={1}", i, sum);
            }
        }
    }
}