using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Day3Task2
{
    public static class ValueCheck
    {


        public static Boolean InputCheck(BigInteger number, int n, int accuracy)
        {
            if (number < 1)
            {
                return false;
            }
            else
                if (n < 1 || n > int.MaxValue)
                {
                    return false;
                }
                else
                    if (accuracy < 1 || accuracy > int.MaxValue)
                    {
                        return false;
                    }
                    else
                        return true;

        }



    }
}
