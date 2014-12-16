using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MSort
    {


        private static int[][] SortedMatrixInit(int[][] matrix)
        {

            int size = 0;
            int[][] sortedMatrix = new int[matrix.Length][];
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    size++;
                    sortedMatrix[i] = new int[size + 1];
                }
                size = 0;
            }


            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {

                    sortedMatrix[i][j] = matrix[i][j];
                }

            }

            return sortedMatrix;


        }

        public int[][] SortBySumm(int[][] matrix)
        {

            int[][] sortedMatrix = new int[matrix.Length][];
            sortedMatrix = SortedMatrixInit(matrix);
            
              int last;
                   for (int i = 0; i < sortedMatrix.Length; i++)
                     {
                         last = sortedMatrix[i].Length-1;
                         sortedMatrix[i][last] = ElementSumm(matrix[i]);
                      }

                


                   Sorting(sortedMatrix);
                  

                       return sortedMatrix;
        }


        public int[][] SortByMax(int[][] matrix)
        {
            int[][] sortedMatrix = new int[matrix.Length][];
            sortedMatrix = SortedMatrixInit(matrix);

            int last;
            for (int i = 0; i < sortedMatrix.Length; i++)
            {
                last = sortedMatrix[i].Length - 1;
                sortedMatrix[i][last] = MaxElement(matrix[i]);
            }

            Sorting(sortedMatrix);

            return sortedMatrix;

        }


        public int[][] SortByMin(int[][] matrix)
        {
            int[][] sortedMatrix = new int[matrix.Length][];
            sortedMatrix = SortedMatrixInit(matrix);


            int last;
            for (int i = 0; i < sortedMatrix.Length; i++)
            {
                last = sortedMatrix[i].Length - 1;
                sortedMatrix[i][last] = MinElement(matrix[i]);
            }

            Sorting(sortedMatrix);

            return sortedMatrix;


        } 




        private static int ElementSumm(int[] arr)
        {

            int summ = 0;
            foreach(int x in arr){
                summ += x;

            }

            return summ;
        }

        private static int MaxElement(int[] arr)
        {
            int max = 0;
            foreach (int x in arr)
            {
                if (x > max)
                    max = x;
            }
            return max;
        }

        private static int MinElement(int[] arr)
        {
            int min=arr[0];
            foreach (int x in arr)
            {
                if (min > x)
                    min = x;
            }
            return min;

        }
        
        private static int[][] Sorting(int[][] matrix)
        {
            int[] temp;
            
            for (int i = 0; i < matrix.Length - 1; i++)
            {

                temp = new int[matrix[i].Length];

                for (int j = i + 1; j < matrix.Length; j++)
                {
                    if (matrix[i][matrix[i].Length - 1] > matrix[j][matrix[j].Length - 1])
                    {


                        temp = matrix[i];


                        matrix[i] = matrix[j];

                       matrix[j] = temp;


                    }
                }
            }

            return matrix;

        }


    }
}
