using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToNumber
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入皮卡丘的HP：");
            int pikachuHp = int.Parse(Console.ReadLine());
            Console.WriteLine("皮卡丘的HP是：{0}", pikachuHp);
        }
    }
}