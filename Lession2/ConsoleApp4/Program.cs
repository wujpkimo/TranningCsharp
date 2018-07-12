using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //notebook Aero15 = new notebook()
            //{
            //    ModelName = "Aero15",
            //    Spec = "I7xxxxx",
            //    Color = "White",
            //    Size = 15.1,
            //    HddSize = 100
            //};

            //Console.WriteLine(Aero15.Size);

            //工程師 bird = new 工程師()
            //{
            //    姓名 = "黃xx",
            //    姓別 = "男"
            //};

            Pokemon 快龍 = new Pokemon()
            {
                name = "快龍",
                CP = 3000,
                candy = 3,
                starDust = 3000
            };

            Console.WriteLine("{0}的CP為{1},升級所需糖果為{2},升級所需星塵為{3}"
                , 快龍.name, 快龍.CP.ToString(), 快龍.candy.ToString(), 快龍.starDust.ToString());
        }
    }

    public class notebook
    {
        public string ModelName;
        public string Spec;
        public string Color;
        public double Size;
        public int HddSize;
    }

    public class 工程師
    {
        public string 姓名;
        public string 姓別;
    }

    public class Pokemon
    {
        public string name;
        public int CP;
        public int candy;
        public int starDust;
    }

    public class EngineerName
    {
    }
}