using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Services;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestValueOperation()
        {
            var calc = new CalculatorServiceImp();
            QueueOperationItem op1 = new QueueOperationItem(OperationType.Addition);
            QueueOperationItem op2 = new QueueOperationItem(OperationType.Multiplication);
            var result=new bool();
            if (calc.ValueOperation(op1.Operation)<calc.ValueOperation(op2.Operation))
                result = true;
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestCalculator1()
        {
            var calc = new CalculatorServiceImp();
            calc.AddNumber("88");
            calc.AddOperation(OperationType.Addition);
            calc.AddNumber("66");
            calc.AddOperation(OperationType.Multiplication);
            calc.AddNumber("2");
            calc.AddOperation(OperationType.Subtraction);
            calc.AddNumber("55");
            var result = calc.GetResult();
            Assert.AreEqual(result, 165);
        }
        [TestMethod]
        public void TestCalculator2()
        {
            var calc = new CalculatorServiceImp();
            calc.AddNumber("33");
            calc.AddOperation(OperationType.Division);
            calc.AddNumber("2");
            calc.AddOperation(OperationType.Multiplication);
            calc.AddNumber("2");
            calc.AddOperation(OperationType.Subtraction);
            calc.AddNumber("55");
            var result = calc.GetResult();
            Assert.AreEqual(result, -22);
        }
        [TestMethod]
        public void TestCalculator3()
        {
            var calc = new CalculatorServiceImp();
            calc.AddNumber("88");
            calc.AddOperation(OperationType.Addition);
            calc.AddNumber("66");
            calc.AddOperation(OperationType.Subtraction);
            calc.AddNumber("2");
            calc.AddOperation(OperationType.Subtraction);
            calc.AddNumber("55");
            var result = calc.GetResult();
            Assert.AreEqual(result, 97);
        }
        [TestMethod]
        public void TestCalculator4()
        {
            var calc = new CalculatorServiceImp();
            calc.AddNumber("88");
            calc.AddOperation(OperationType.Inverse);
            calc.AddOperation(OperationType.Squared);
            calc.AddOperation(OperationType.Inverse);
            calc.AddOperation(OperationType.Sqrt);
            calc.AddOperation(OperationType.Addition);
            calc.AddNumber("66");
            calc.AddOperation(OperationType.Multiplication);
            calc.AddNumber("2");
            calc.AddOperation(OperationType.Subtraction);
            calc.AddNumber("55");
            var result = calc.GetResult();
            Assert.AreEqual(result, 165);
        }
        [TestMethod]
        public void TestCalculator5()
        {

        }
    }
}
