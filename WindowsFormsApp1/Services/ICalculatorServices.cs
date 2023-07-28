using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Services
{
    interface ICalculatorServices
    {
        /*
        double Addition(double x, double y);
        double Subtraction(double x, double y);
        double Division(double x, double y);
        double Multiplication(double x, double y);
        double Squared(double x);
        double Inv(double x);
        double Module(double x, double y);
        double Sqrt(double x);
        */
        #region Marius
        void AddNumber(string number);
        void AddOperation(OperationType operationType);
        void CancelAllEntries();
        void CancelEntry();
        double GetResult(); 
        #endregion

    }
}
