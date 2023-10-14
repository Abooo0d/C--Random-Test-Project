using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxs
{
    class Program
    {
        class Box
        {
            private double Height,Width, Debth;
            public Box()
            {
                Height = 1;
                Width = 1;
                Debth = 1;
            }
            public Box(double h, double w, double d)
            {
                Height = h;
                Width = w;
                Debth = d;
            }
            public void volume()
            {
                Console.Write("The Volume is ");
                Console.WriteLine(Height * Width * Debth);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("The Height Is :");
            double a = int.Parse(Console.ReadLine());
            Console.Write("The Width Is :");
            double b = int.Parse(Console.ReadLine());
            Console.Write("The Debth Is :");
            double c = int.Parse(Console.ReadLine());
            Box b1 = new Box();
            Box b2 = new Box(a, b, c);
            b1.volume();
            b2.volume();
        }
    }
}
