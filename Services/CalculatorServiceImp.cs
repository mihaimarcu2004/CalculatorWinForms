using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsApp1;

namespace WindowsFormsApp1.Services
{

    public class CalculatorServiceImp : ICalculatorServices
    {
        /*
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
*/
        #region Marius
        private readonly List<IQueueItem> _listOfOperation = new List<IQueueItem>();
        Stack <QueueNumberItem> values = new Stack<QueueNumberItem>();
        Stack<QueueOperationItem> operations = new Stack<QueueOperationItem>();
      

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
      
        public int ValueOperation(OperationType op)
        {
            
            
            switch (op)
            {
                case OperationType.Addition:
                    return 1;
                case OperationType.Subtraction:
                    return 1;
                case OperationType.Division:
                    return 2;
                case OperationType.Multiplication:
                    return 2;
                case OperationType.Module:
                    return 2;
                default:
                    return 3;


            }
           


           
        }
        public double Calculeaza(double prim, double secund, QueueOperationItem op)
        {
            switch (op.Operation)
            {
                case OperationType.Addition:
                    prim += secund;
                    break;
                case OperationType.Subtraction:
                    prim -= secund;
                    break;
                case OperationType.Division:
                    prim /= secund;
                    break;
                case OperationType.Multiplication:
                    prim *= secund;
                    break;
                case OperationType.Sqrt:
                    prim = Math.Sqrt(prim);
                    break;
                case OperationType.Inverse:
                    prim = 1 / prim;
                    break;
                case OperationType.Module:
                    prim %= secund;
                    break;
                case OperationType.Squared:
                    prim *= prim;
                    break;
                case OperationType.PlusMinus:
                    prim *= -1;
                    break;
                case OperationType.EraseLastDigit:
                    string x = prim.ToString();
                    x = x.Remove(x.Length - 1, 1);
                    prim = Convert.ToDouble(x);
                    break;
            }
            return prim;

        }
        public double GetResult()
        {
            double resultingNumber = 0;
          
           double temporaryNumber = 0;
               
               
            foreach (var item in _listOfOperation)
            {
                switch (item)
                {
                    case QueueNumberItem number:
                        {
                           
                            temporaryNumber += number.Number;
                            if(item==_listOfOperation.Last())
                            {
                                QueueNumberItem aux = new QueueNumberItem(temporaryNumber);

                                values.Push(aux);

                                temporaryNumber = 0;
                             
                            }
                            break;
                        }
                    case QueueOperationItem operation:
                        {
                            if(ValueOperation(operation.Operation)==3)
                            {

                                temporaryNumber = Calculeaza(temporaryNumber, 0, operation);
                            }
                            else if(operations.Count>0)
                            {
                                QueueOperationItem op;
                                op = (QueueOperationItem)operations.Peek();
                                double prim = temporaryNumber;
                                while (operations.Count()>0 && ValueOperation(operation.Operation) <= ValueOperation(operations.Peek().Operation))
                                {

                                    op = operations.Peek();
                                    double secund = Convert.ToDouble(values.Peek().Number);
                                    values.Pop();
                                    prim=Calculeaza(secund, prim, op);
                                    temporaryNumber = prim;
                                    operations.Pop();
                                   
                          
                                  
                                }
                                QueueNumberItem auxin = new QueueNumberItem(temporaryNumber);
                                values.Push(auxin);
                                temporaryNumber = 0;
                                operations.Push(operation);



                            }
                            else
                            {
                                QueueNumberItem aux = new QueueNumberItem(temporaryNumber);

                                values.Push(aux);

                                temporaryNumber = 0;
                                operations.Push(operation);

                            }
                            break;


                        }
                        
                            
                            
                        
                    default:
                        {
                            throw new NotImplementedException("Unknown item in queue");
                        }
                }
            }
            while(operations.Count()>0)
            {
                QueueNumberItem num1 = values.Peek();
                values.Pop();
                QueueNumberItem num2 = values.Peek();
                values.Pop();
                QueueOperationItem op = operations.Peek();
                operations.Pop();
                num1.Number = Calculeaza(num2.Number, num1.Number, op);
                values.Push(num1);

            }
            double x = values.Peek().Number;
            values.Pop();
            _listOfOperation.Clear();
            return x;
        }
        #endregion
        
    }
    
}
