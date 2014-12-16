using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ArrayInit
    {



        public int[] Init(int[] arr)
        {
            Random rd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(0, 100);

            }

            return arr;


        }


        public int[][] Init(int[][] matrix)
        {
            Random rd = new Random();


            for (int i = 0; i < matrix.Length; i++)
                matrix[i] = new int[rd.Next(1, 20)];

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = rd.Next(0, 100);

                }

            }




            return matrix;

        }


    }
}
