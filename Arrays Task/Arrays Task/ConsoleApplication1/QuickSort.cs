using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class QuickSort
    {



        public void QSort(int[] mass,int start,int last)
        {
           
           int p = mass[(last - start)/2 + start]; 
           int temp;
           int i = start;
           int j = last; 
          
            while(i <= j)
           {
             while(mass[i] < p && i <= last)  ++i; 
             while(mass[j] > p && j >= start) --j; 
             if(i <= j)                
              {
                 temp = mass[i];   
                 mass[i] = mass[j]; 
                 mass[j] = temp; 
                 ++i; --j;       
               }
            }
            if(j > start) QSort(mass, start, j);
            if(i < last)  QSort(mass, i, last);
          }
        }



    }

