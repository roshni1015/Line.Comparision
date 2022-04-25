using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Comparision
{
    public class ComparetoMethods
    {
        public void comparetomethods(double finalResult, double finalResult2)
        {
            int res = finalResult.CompareTo(finalResult2);
            Console.WriteLine(res);
            if (res == 0)
            {
                Console.WriteLine("Lengths are equal!");
            }
            if (res > 0)
            {
                Console.WriteLine("Line 1 is greator than line 2 ");
            }
            else
            {
                Console.WriteLine("Line 2 is greator than line 1 ");
            }

        }
    }
}
