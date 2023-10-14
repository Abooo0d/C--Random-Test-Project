
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class studeent
    {
        private int id;
        private string student_name;
        private double credit;
        ~studeent()
        {
            Console.WriteLine("Destructor");
        }
        public studeent()
        {
            id = 200;
            student_name = "Samer Hassan";
            credit = 76.5;
        }
        public void setstudent(int d, string s, double c)
        {
            id = d;
            student_name = s;
            credit = c;
        }
        public void print_stud()
        {
            Console.WriteLine("id: " + id + "\n" +"student name: "+student_name+ "\n" + "credit: "+credit);
        } 
    }
    class Program
    {
       public  class test
        {
            public static void Main(string[] args)
            {
                studeent ob = new studeent();
                studeent ob1 = new studeent();
                studeent ob2 = new studeent();
                studeent ob3 = new studeent(30, "ali", 25);
                ob.setstudent(230, "Ali", 85);
                ob1.setstudent(60, "ahmad", 5);
                ob.print_stud();
                ob1.print_stud();
                ob2.print_stud();
            }
        }
       
    }
}
