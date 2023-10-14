using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Customer:Person
    {
        public Customer()
        {
            _ChepmentAddres ="none";
        }
        public Customer(int i,string n,string a,string c):base(i,n,a)
        {
            Console.WriteLine("==Constractor===");
            _ChepmentAddres = c;
            Console.WriteLine("====End====");
        }
        private string _ChepmentAddres;

        public string ChepmentAddres
        {
            get { return _ChepmentAddres; }
            set { _ChepmentAddres= value; }
        }

        public override void printtype()
        {
            Console.WriteLine("Customer");
        }
        public override void printdata()
        {
            Console.WriteLine("=======Print data=========");
            Console.WriteLine(id+"\n"+name + "\n" +addres + "\n" +ChepmentAddres);
            Console.WriteLine("========end============");
        }


    }
}
