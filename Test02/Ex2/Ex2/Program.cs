using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        class point
        {
            private int x, y;
            public point()
            {
                x = 0;
                y = 0;

            }
            public point(int new_x, int new_y)
            {
                if (new_x < 0)
                {
                    new_x *= -1;
                }
                if (new_y < 0)
                {
                    new_y *= -1;
                }
                x = new_x;
                y = new_y;
            }
            public void print_Point()
            {
                Console.Write("the Point is : {0},{1} \n", x, y);
            }
            ~point()
            {
                Console.WriteLine("This is The Destructor.");
            }
        }

        public class point_test
        {
            static void Main(string[] args)
            {
                point p1 = new point(20, 30);
                point p2 = new point();
                p1.print_Point();
                p2.print_Point();
            }
        }
    }
}
