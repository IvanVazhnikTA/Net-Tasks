using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day4Task;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {

            Polynomial p1 = new Polynomial(2.5, 5, 4.78);
            Polynomial p2 = new Polynomial(2, 7, 8.8, 1.1);
            Polynomial p3;
            Console.WriteLine(p1.Calculate(0.3));
            Console.WriteLine(p2.Calculate(0.1));
            Console.ReadLine();
            p3 = p1 + p2;
            Console.WriteLine(p3);
            p3 = p1 * p2;
            Console.WriteLine(p3.ToString());
            p3 = p1 - p2;
            Console.WriteLine(p3.ToString());
            Console.WriteLine(p2 == p3);

            Console.ReadLine();


        }
    }
}
