using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Program_1
{
    class Program
    {
        static void print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "\t");
            }
            Console.WriteLine();
        }
        static void selectionSort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int t;
                        t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
            }
        }

        static void mergeSort(int[] a, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                mergeSort(a, start, mid);
                mergeSort(a, mid + 1, end);
                merge(a, start, end);
            }
        }
        static void merge(int[] a, int start, int end)
        {
            int mid = (start + end) / 2;
            int i = start, j = mid + 1, k = start;
            int[] temp = new int[a.Length];
            while (i <= mid && j <= end)
            {
                if (a[i] < a[j])
                {
                    temp[k] = a[i];
                    i++;
                    k++;
                }
                else
                {
                    temp[k] = a[j];
                    j++;
                    k++;
                }
            }
            while (i <= mid)
            {
                temp[k] = a[i];
                i++;
                k++;
            }
            while (j <= end)
            {
                temp[k] = a[j];
                j++;
                k++;
            }

            for (int t = start; t <= end; t++)
            {
                a[t] = temp[t];
            }
        }

        static void Main(string[] args)
        {
            
            // test selection Sort 
            Console.WriteLine("selection Sort");
            int[] a = { 55, 11, 78, 66, 1, 5, 99 };
            print(a);
            selectionSort(a);
            print(a);
            
            
            // test Merge Sort
            Console.WriteLine("----------------------");
            Console.WriteLine("Merge Sort");
            int[] b = { 55, 11, 78, 66, 1, 5, 99 };
            print(b);
            mergeSort(b, 0, b.Length - 1);
            print(b);
            
            Console.ReadKey();
        }
    }

}
