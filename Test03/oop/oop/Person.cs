using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Person
    {
        private int _id;
        private string _name;
        private string _addres;

        public Person(string name = "Person")
        {
            _id = -1;
            _name = "none";
            _addres = "none";
        }
        public Person(int i, string n, string a,string name = "Person")
        {
            Console.WriteLine("==Constractor===");
            _id = i;
            _name = n;
            _addres = a;
            Console.WriteLine("====End====");
        }
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string addres
        {
            get { return _addres; }
            set { _addres = value; }
        }
        private string _printdata()
        {
            return _id + "\t" + _name + "\t" + _addres;
        }
        public virtual void printdata()
        {
            Console.WriteLine("=======Print data=========");
            Console.WriteLine(_printdata().Replace("\t", "\n"));
            Console.WriteLine("========end============");
        }

        public virtual void printtype()
        {
            Console.WriteLine("Person");
        }
    }
}
