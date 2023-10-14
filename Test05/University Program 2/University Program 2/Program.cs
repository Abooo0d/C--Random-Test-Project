using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Program_2
{
    class Program
    {
        static int ls(int x, int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] == x)
                    return i;
            return -1;
        }
        static int binSearch(int x, int[] a, int start, int end)
        {
            if (start > end)
            {
                return -1;
            }
            else if (start == end)
            {
                if (x == a[start])
                    return start;
                else
                    return -1;
            }
            else
            {
                int mid = (start + end) / 2;
                if (x == a[mid])
                    return mid;
                else if (x < a[mid])
                    return binSearch(x, a, start, mid - 1);
                else // if (x > a[mid])
                    return binSearch(x, a, mid + 1, end);
            }
        }
        static int bs(int x, int[] a)
        {
            return binSearch(x, a, 0, a.Length - 1);
        }
        static void Main(string[] args)
        {
            int res;
            // test linear search
            int[] b = { 10, 5, 77, 9, 45 };
            res = ls(10, b);
            if (res == -1)
                Console.WriteLine("Not found");
            else
                Console.WriteLine(res);
            

            // test binary search
            int[] c = { 1, 5, 9, 55, 105, 310, 999 };
            res = bs(9, c);
            if (res == -1)
                Console.WriteLine("Not found");
            else
                Console.WriteLine(res);


            // test 2binary search 
            int[] d = { 1, 5, 9, 55, 105, 310, 999 };
            res = binSearch(9, c, 0, d.Length);
            if (res == -1)
                Console.WriteLine("Not found");
            else
                Console.WriteLine(res);

    
            Console.ReadKey();
        }
    }

}
