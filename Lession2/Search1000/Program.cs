using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search1000
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int i = 0;
            int sum = 0;

            do
            {
                if (sum > 500)
                {
                    continue;
                }
                i++;
                sum += i;
                Console.WriteLine("i={0}, sum={1}", i, sum);
            } while (sum < 1000);
            Console.WriteLine(i);
        }
    }
}