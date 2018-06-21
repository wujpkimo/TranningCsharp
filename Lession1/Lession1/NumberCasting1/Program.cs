using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCasting1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double a = 3.1415926;
            float b = a;    // 這是不合法的
            float c = (float)a; //明確轉換
        }
    }
}