using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Services
{
    interface ICalculatorServices
    {
        int Addition(int x, int y);
        int Subtraction(int x, int y);
    }
}
