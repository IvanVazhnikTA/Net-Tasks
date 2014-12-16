using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

       

        static void Main(string[] args)
        {
            Random rd = new Random();

            int ARRSIZE = rd.Next(10, 30);
            int MATRIXSIZE = rd.Next(1,6);      
      

            ArrayInit ai = new ArrayInit();
            MergeSort ms = new MergeSort();
            QuickSort qs = new QuickSort();
            PrintResult print = new PrintResult();
            MSort mats = new MSort();

            int[][] mat = new int[MATRIXSIZE][];

            int[] arr = new int[ARRSIZE];
            int[] mSortedArray = new int[arr.Length];
            int[] qSortedArray = new int[arr.Length];
           
            arr = ai.Init(arr);
                       
            System.Console.WriteLine("New Array:");

            print.Print(arr);
           
            mSortedArray = ms.Sort(arr);

            System.Console.WriteLine("Merge sorted array:");
            print.Print(mSortedArray);          
            qSortedArray = arr;
            qs.QSort(qSortedArray, 0, qSortedArray.Length - 1);

            System.Console.WriteLine("Quick sorted array:");
            print.Print(qSortedArray);

            System.Console.WriteLine("New Matrix:");
            mat = ai.Init(mat);            
            print.Print(mat);

            System.Console.WriteLine("Matrix sorted by element summ: ");
            print.Print(mats.SortBySumm(mat));
            print.ReversePrint(mats.SortBySumm(mat));

            System.Console.WriteLine("Matrix sorted by max element: ");
            print.Print(mats.SortByMax(mat));
            print.ReversePrint(mats.SortByMax(mat));

            System.Console.WriteLine("Matrix sorted by min element: ");
            print.Print(mats.SortByMin(mat));
            print.ReversePrint(mats.SortByMin(mat));
           

        }

        

    }
}
