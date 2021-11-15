using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public static class Calculator
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Subtract(double x, double y)
        {
            return x - y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static double Divide(double x, double y)
        {
            return x / y;
           /*solucion divicion entre 0 test*/
           /*
           if (y != 0)
           {
               return x / y; 
           }
           else
           {
                return 0;
           }*/
        }
        public static int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }
        public static int Min(int a, int b)
        {
            return (a < b) ? a : b;
        }

        public static IEnumerable<int> GetOddNumbers(int limit)
        {
            for (var i = 0; i <= limit; i++)
                if (i % 2 != 0)
                    yield return i;
        }
    }
}
