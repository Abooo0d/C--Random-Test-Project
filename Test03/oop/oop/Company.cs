using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Company:BaseClass
    {
        public override string name
        {
            get { return name; }
            set { _name = value; }
        }
        public override int id
        {
            get { return _id;}
            set { _id = value; }
        }
    }
}
