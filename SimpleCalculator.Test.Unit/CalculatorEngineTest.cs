using System;
using CalculatorEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {

            int number1 = 1;
            int number2 = 2;
            double result = calculatorEngine.Calculate("add", number1, number2);
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = calculatorEngine.Calculate("+", number1, number2);
            Assert.AreEqual(3, result);

        }
        [TestMethod]
        public void SubsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {

            int number1 = 1;
            int number2 = 2;
            double result = calculatorEngine.Calculate("subtract", number1, number2);
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void SubsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {

            int number1 = 1;
            int number2 = 2;
            double result = calculatorEngine.Calculate("-", number1 , number2);
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void DivsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {

            int number1 = 1;
            int number2 = 2;
            double result = calculatorEngine.Calculate("divide", number1, number2);
            Assert.AreEqual(3, result);

        }
        [TestMethod]
        public void DivsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {

            int number1 = 1;
            int number2 = 2;
            double result = calculatorEngine.Calculate("/", number1 , number2);
            Assert.AreEqual(3, result);
        }

      

        public void MultTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {

            int number1 = 1;
            int number2 = 2;
            double result = calculatorEngine.Calculate("multiply", number1, number2);
            Assert.AreEqual(2, result);

        }

        [TestMethod]
        public void MultTwoNumbersAndReturnsValidResultForSymbolOperation()
        {

            int number1 = 1;
            int number2 = 2;
            double result = calculatorEngine.Calculate("*", number1 , number2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void GetsRemainderFromTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {

            int number1 = 1;
            int number2 = 2;
            double result = calculatorEngine.Calculate("modulus", number1, number2);
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void GetsRemainderFromTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = calculatorEngine.Calculate("%", number1, number2);
            Assert.AreEqual(3, result);

        }
    }
}