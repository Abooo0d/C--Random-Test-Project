using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Employee:Person
    {
        public Employee()
        {
            _job = "none";
        }
        public Employee(int i,string n,string a,string j):base(i,n,a)
        {
            Console.WriteLine("==Constractor===");
            _job = j;
            Console.WriteLine("====End====");
        }
        private string _job;
        public string job
        {
            get { return _job; }
            set { _job = value; }
        }
        public override void printdata()
        {
            Console.WriteLine("=======Print data=========");
            Console.WriteLine(id+"\n"+name+"\n"+addres+"\n"+job);
            Console.WriteLine("========end============");
        }

        public new virtual void printtype()
        {
            Console.WriteLine("Employee");
        }
    }
}
