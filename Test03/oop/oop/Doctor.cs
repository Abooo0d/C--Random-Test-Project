using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Doctor:Employee
    {
        public Doctor()
        {
            _Doctorid = -1;
        }
        public Doctor(int i,string n,string a,string j,int d):base(i,n,a,j)
        {
            Console.WriteLine("==Constractor===");
            _Doctorid = d;
            Console.WriteLine("====End====");
        }

        private int _Doctorid;

        public int Doctorid
        {
            get { return _Doctorid; }
            set { _Doctorid = value; }
        }
        public override void printtype()
        {
            Console.WriteLine(GetType().Name);
        }
        public override void printdata()
        {
            Console.WriteLine("=======Print data=========");
            Console.WriteLine(id+"\n"+name + "\n" +addres + "\n" +job + "\n" +Doctorid);
            Console.WriteLine("========end============");
        }
    }
}
