using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCasting2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            float a = 3.1415926f;
            double b = a;    // 這是合法的  隱含轉換
            double c = (double)a; //明確轉換
        }
    }
}