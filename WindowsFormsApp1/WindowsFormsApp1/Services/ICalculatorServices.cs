using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Services
{
    interface ICalculatorServices
    {
        double Addition(double x, double y);
        double Subtraction(double x, double y);
        double Division(double x, double y);
        double Multiplication(double x, double y);
        double Squared(double x);
        double Inv(double x);
        double Module(double x, double y);
        double Sqrt(double x);

    }
}
