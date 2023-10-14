using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_OOP
{
    class Program
    {
        //Normal Type Of Method:
        private static void m1( string name)
        {
            Console.WriteLine("Hello " + name);
        }

        //Methods Return Values:
        //This Type Has A Data Type Of Retured Data.
        //"return" It's Required To Return A Value Of The Same Data Type Of The Method.
        //If Ther Was More Than One Condetion FOr The Method "return"It's Required In All Of It.
        //In THis Type We Have To Set The Returned Value From The Method To Avirable The Use It.
        private static int m2()
        {
            int x = 10, y = 20;
            if (x > y)
                return x;
            else

                return y;
        }

        //the Types Of parameters In Methods:

        //Type One:The Normal parameters.
        //In This Type Any Changes On The Parameter Will Not Efecte The Original Variable value It Well Efecte The value Inside The Method.
        private static void m3(string name)
        {
            name = "Ahmad";
            Console.WriteLine(name);
        }

        //Type Tow:References Parameters.
        //In This Type The Parameters And The Orginal Variable Will Be Effected Together In Any Changes In The Method.
        //In This Type When We Declerat A Parameters We Add "ref" Befor It.
        //When We Use It Also We Have To Add "ref" Before The Parameters. 
        //We Can't Use A Null-Value Variable 
        private static void m4(ref string name)
        {
            Console.WriteLine(name);
            name = "Kamel";
            Console.WriteLine(name);
        }

        //Type Three:Out Parameters:
        //In This Type The Parameters And The Orginal Variable Will Be Effected Together In Any Changes In The Method.
        //In This Type When We Declerat A Parameters We Add "out" Befor It.
        //When We Use It Also We Have To Add "out" Before The Parameters. 
        //On This Type We Can Use A Null-Value Variable. 
        //We Use This Type Wen We Need To Assing A Value The Variable.

        private static void m5(out string name)
        {
            name = "Hassan";
            Console.WriteLine(name);
        }

        static void Main(string[] args)
        {
            

            string n = "Ahmad";
            m1(n);
            Console.WriteLine("=======================================");
            Console.WriteLine(m2());
            Console.WriteLine("=======================================");
            m3(n);
            Console.WriteLine("=======================================");
            m4(ref n);
            Console.WriteLine("=======================================");
            m5(out n);
            Console.WriteLine(n);
            Console.WriteLine("=======================================");

            int[] arr1 = { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = { 6, 5, 4, 3, 2, 1 };
            Combain_Arrays ca = new Combain_Arrays();
            ca.printSum(arr1, arr2);

            string all=Combain_Arrays.personeinfo();
            string[] a = all.Split(';');
            Console.WriteLine("  Name   :" + a[0]);
            Console.WriteLine("PassWord :" + a[1]);


            Console.ReadKey();
        }
    }
}
