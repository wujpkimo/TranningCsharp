using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string condition = string.Empty;
            int i = 0;
            while (i <= 9)
            {
                i++;
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                }
            }
            //Console.WriteLine(condition);
        }
    }
}