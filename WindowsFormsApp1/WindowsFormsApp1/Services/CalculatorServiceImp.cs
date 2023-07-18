using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Services
{
    public class CalculatorServiceImp : ICalculatorServices
    {
        public double Addition(double x, double y)
        {
            return x + y;
        }

        public double Subtraction(double x, double y)
        {
            return x - y;
        }
        public double Division(double x, double y)
        {
            try
            {
                return x / y;
            }
            catch
            {
                Console.WriteLine("nu se poate imparti la 0");
                return 0;
            }
        }
        public double Multiplication(double x, double y)
        {
            return x * y;
        }
        public double Squared(double x)
        {
            return x * x;
        }
        public double Inv(double x)
        {
            return 1 / x;
        }
        public double Module(double x, double y)
        {
            return x % y;
        }
        public double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }
    }
}
