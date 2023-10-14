using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class my {
        private int m;
        public my(){ m = 0; }
        public void my1(int x) {
            if (x < 100)
            {
                x *= 4;
            }
            else
                x *= 2;
            this.m = x;



        }

        public void print() { Console.WriteLine(m); }

    }
    class Program
    {
        static void Main(string[] args)
        {
            my ob = new my();
            my ob1 = new my();
            ob.my1(9);
            ob.print();
            ob1.print();
            Console.ReadKey();
        }
    }
}
