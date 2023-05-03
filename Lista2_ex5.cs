using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b, h, a;

            Console.Write("Digite a base:");
            b = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura:");
            h = double.Parse(Console.ReadLine());

            a = b * h;

            Console.WriteLine("área = {0}", a);

            if (a > 100)
                Console.WriteLine("terreno grande");
            else
                Console.WriteLine("terreno pequeno");
        }
    }
}
