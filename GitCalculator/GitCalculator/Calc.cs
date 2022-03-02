using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitCalculator
{
    internal class Calc
    {
        public double plus(double a, double b)
        {
            double result = a + b;
            Console.WriteLine("Result of addition is: " + result);
            return result;
        }

        public double minus(double a, double b)
        {
            double result = a - b;
            Console.WriteLine("Result of subtraction is: " + result);
            return result;
        }

        public double multiply(double a, double b)
        {
            double result = a * b;
            Console.WriteLine("Result of multiplication is: " + result);
            return result;
        }

        public double div(double a, double b)
        {
            double result = 0;
            if (b == 0)
            {
                Console.Write("CANNOT DIVIDE BY ZERO");
                return result;
            }
            else
            {
                result = a / b;
                Console.WriteLine("Result of division is: " + result);
                return result;
            }
        }
    }
}