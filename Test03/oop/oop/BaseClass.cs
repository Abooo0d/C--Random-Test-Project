using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    abstract class BaseClass
    {
        protected  string _name;
        protected int _id;

        public abstract string name { get; set; }
        public abstract int id{ get; set; }
    }
}
