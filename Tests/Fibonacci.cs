using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class Fibonacci
    {
        public static double Fib(int n)
        {
            if (n < 2)
            {
                return n;
            }
            else
            {
                double[] fibArray = new double[n + 1];
                return CalcFib(n, fibArray);
            }
        }

        static double CalcFib(int n, double[] fibArray)
        {
            if (n < 2)
            {
                return n;
            }
            else if (fibArray[n] != 0)
            {
                return fibArray[n];
            }
            else
            {
                fibArray[n] = CalcFib(n - 1, fibArray)
                            + CalcFib(n - 2, fibArray);

                return fibArray[n];
            }
        }
    }
}
