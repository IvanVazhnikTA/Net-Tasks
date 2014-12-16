using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day3Task1;
using System.Numerics;

namespace Runner
{
    class Runner
    {
        static void Main(string[] args)
        {

            byte byteValue = 124;
            Console.WriteLine(String.Format(new BinaryFormatter(),
                                            "{0:B}", byteValue));

            int intValue = 23045;
            Console.WriteLine(String.Format(new BinaryFormatter(),
                                            "{0:B}", intValue));

            ulong ulngValue = 31906574882;
            Console.WriteLine(String.Format(new BinaryFormatter(),
                                            "{0:B}",
                                            ulngValue));

            BigInteger bigIntValue = BigInteger.Multiply(Int64.MaxValue, 2);
            Console.WriteLine(String.Format(new BinaryFormatter(),
                                            "{0:B}",
                                            bigIntValue));

            Console.ReadLine();

        }
    }
}
