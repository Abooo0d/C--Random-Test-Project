using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static oop.testthread;

namespace oop
{
    class testCabs
    {
        //Encapsulation
        private int _myVar;
        public int myvar
        {
            get { return _myVar; }
            set { _myVar = value; }
        }
        public void testp(params int[] nums)
        {
            int z = 0;
            for (int i = 0; i < nums.Count() - 1; i++)
            {
                z = z + nums[i];
            }
            Console.WriteLine(z);
        }
    }
    
    class testthread
    {
        static readonly object o = new object();
        public void print()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// To Sleep For  SomeTime
        /// </summary>
        /// <param name="Seconds">the Time You Want To Sleep</param>
        public static void Wait(int Seconds)
        {
            Thread.Sleep(Seconds * 1000);
        }
        public static void printnumber()
        {
            lock(o)
            {
                Thread.Sleep(200);
                Console.WriteLine("01587465489");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            testCabs t1 = new testCabs();
            t1.myvar = 100;

            Person p1 = new Person();

            Employee e1 = new Employee(4, "abod", "darea", "Programer");

            Customer c1 = new Customer(5, "ahmad", "darea", "mazah");

            Doctor d1 = new Doctor();

            p1.printdata();
            e1.printdata();
            c1.printdata();
            d1.printdata();

            int i = 5;

            

            Console.WriteLine("Testing The Defrens Between The Override And New");
            //Testing The Difference Between The Override And New
            Person p4 = new Employee();
            Person p5 = new Customer();
            Console.Write("With new :  ");
            p4.printtype();
            Console.Write("With override :  ");
            p5.printtype();
            //End Testing

    */
    
            testCabs t = new testCabs();
            t.testp(5, 6, 5, 2, 3, 1, 5, 6);

            //implicit & explicit Converrtion
            Digit d1 = 77.5;
            double d2 = d1;

            Programer p1 = new Programer();
            Gamer g1 = new Gamer();
            p1 = (Programer)g1;
            g1 = (Gamer)p1;
            //End
            //Test Threading
            /*
            testthread t1 = new testthread();
            testthread t2 = new testthread();

            Thread th1 = new Thread(t1.print);
            Thread th2 = new Thread(t2.print);
            th1.Start();
            th2.Start();
            
            Console.WriteLine("1");
            Wait(2);
            Console.WriteLine("2");
            Wait(2);
            Console.WriteLine("3");
            Wait(2);*/
           
            for (int i = 0; i < 10; i++)
            {
                Thread th1 = new Thread(printnumber);
                th1.Start();
            }           
            //End
        }
    }
}
