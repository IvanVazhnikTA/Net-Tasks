using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Day3Task2
{
    public static class Newton
    {



        public static double NCalc(BigInteger number, int n, int accuracy)
        {

            if (ValueCheck.InputCheck(number, n, accuracy))
            {
                double x = (double)number / 2;

                for (int i = 1; i < accuracy; i++)
                {

                    x = ((n - 1) * x + ((double)number / Math.Pow(x, n - 1))) / n;

                }

                return x;
            }
            else
                return 0;
            
        }




    }
}
