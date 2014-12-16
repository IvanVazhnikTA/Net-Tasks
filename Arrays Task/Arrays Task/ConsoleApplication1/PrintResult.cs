using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PrintResult
    {

        public void Print(int[] arr)
        {

            foreach (int x in arr)
            {
                System.Console.Write(x + " ");
            }
            System.Console.WriteLine();
            System.Console.ReadLine();
        }

        public void Print(int[][] matrix)
        {

            for (int i = 0; i < matrix.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", matrix[i][j], j == (matrix[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
            System.Console.ReadLine();
        }


        public void ReversePrint(int[][] matrix)
        {

            for (int i = matrix.Length-1; i > -1; i--)
            {
                System.Console.Write("Element({0}): ", i);

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", matrix[i][j], j == (matrix[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
            System.Console.ReadLine();



        }

    }
}
