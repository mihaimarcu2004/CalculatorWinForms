using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

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
            return x / y;
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

        #region Marius
        private readonly List<IQueueItem> _listOfOperation = new List<IQueueItem>();

        public void AddNumber(string number)
        {
            if (double.TryParse(number, out double inputNumber))
            {
                _listOfOperation.Add(new QueueNumberItem(inputNumber));
            }
        }

        public void AddOperation(OperationType operationType)
        {
            _listOfOperation.Add(new QueueOperationItem(operationType));
        }

        public void CancelAllEntries()
        {
            _listOfOperation.Clear();
        }

        public void CancelEntry()
        {
            if (_listOfOperation.Count > 0)
            {
                _listOfOperation.RemoveAt(_listOfOperation.Count - 1);
            }
        }

        public double GetResult()
        {
            double resultingNumber = 0;
            double temporaryNumber =0;

            foreach (var item in _listOfOperation)
            {
                switch (item)
                {
                    case QueueNumberItem number:
                        {
                            temporaryNumber = number.Number;
                            break;
                        }
                    case QueueOperationItem operation:
                        {
                            switch (operation.Operation)
                            {
                                case OperationType.Addition:
                                    resultingNumber += temporaryNumber;
                                    break;
                                case OperationType.Subtraction:
                                    resultingNumber -= temporaryNumber;
                                    break;
                                case OperationType.Division:
                                    resultingNumber /= temporaryNumber;
                                    break;
                                case OperationType.Multiplication:
                                    resultingNumber *= temporaryNumber;
                                    break;
                                default:
                                    throw new NotImplementedException("Unknown operation type");
                            }
                            break;
                        }
                    default:
                        {
                            throw new NotImplementedException("Unknown item in queue");
                        }
                }
            }
            return resultingNumber;
        }
        #endregion
    }
}
