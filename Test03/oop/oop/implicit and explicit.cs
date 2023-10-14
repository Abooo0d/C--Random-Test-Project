using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Digit
    {
        double val;
        public Digit(double d)
        {
            val = d;
        }
        public static implicit operator double(Digit d)
        {
            return d.val;
        } 
        public static implicit operator Digit(double d)
        {
            return new Digit(d);

        }
    }
    class Programer
    {
        public static explicit operator Gamer(Programer p)
        {
            return new Gamer();
        } 
    }
    class Gamer
    {
        public static explicit operator Programer(Gamer g)
        {
            return new Programer();
        } 
       
    }
}
