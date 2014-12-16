using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Task
{
    public class Polynomial
    {
       private double[] ceff;

       public Polynomial(params double[] coefficients)
       {
           this.ceff = coefficients;
       }


       public double this[int n]
       {
           get { return ceff[n]; }
           set { ceff[n] = value; }
       }

       public int Order
       {
           get { return ceff.Length; }
       }


       public double Calculate(double x)
       {
           int n = ceff.Length - 1;
           double result = ceff[n];
           for (int i = n - 1; i >= 0; i--)
           {
               result = x * result + ceff[i];
           }
           return result;
       }

       public override string ToString()
       {
           return string.Format("Coefficients:*" + string.Join(";*", ceff));
       }

       public static Polynomial operator +(Polynomial pFirst, Polynomial pSecond)
       {
           int itemsCount = Math.Max(pFirst.ceff.Length, pSecond.ceff.Length);
           var result = new double[itemsCount];
           for (int i = 0; i < itemsCount; i++)
           {
               double a = 0;
               double b = 0;
               if (i < pFirst.ceff.Length)
               {
                   a = pFirst[i];
               }
               if (i < pSecond.ceff.Length)
               {
                   b = pSecond[i];
               }
               result[i] = a + b;
           }
           return new Polynomial(result);
       }

        
       public static Polynomial operator -(Polynomial pFirst, Polynomial pSecond)
       {
           int itemsCount = Math.Max(pFirst.ceff.Length, pSecond.ceff.Length);
           var result = new double[itemsCount];
           for (int i = 0; i < itemsCount; i++)
           {
               double a = 0;
               double b = 0;
               if (i < pFirst.ceff.Length)
               {
                   a = pFirst[i];
               }
               if (i < pSecond.ceff.Length)
               {
                   b = pSecond[i];
               }
               result[i] = a - b;
           }
           return new Polynomial(result);
       }


       public static Polynomial operator *(Polynomial pFirst, Polynomial pSecond)
       {
           int itemsCount = pFirst.ceff.Length + pSecond.ceff.Length - 1;
           var result = new double[itemsCount];
           for (int i = 0; i < pFirst.ceff.Length; i++)
           {
               for (int j = 0; j < pSecond.ceff.Length; j++)
               {
                   result[i + j] += pFirst[i] * pSecond[j];
               }
           }

           return new Polynomial(result);
       }

       public static bool operator ==(Polynomial pFirst, Polynomial pSecond)
       {
           if (pFirst.ceff.Length != pSecond.ceff.Length)
           {
               return false;
           }
           for (int i = 0; i < pFirst.ceff.Length; i++)
           {
               if (pFirst[i] != pSecond[i])
               {
                   return false;
               }
           }
           return true;
       }

       public static bool operator !=(Polynomial pFirst, Polynomial pSecond)
       {
           return !(pFirst == pSecond);
       }

    }
}
