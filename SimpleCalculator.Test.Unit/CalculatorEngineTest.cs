using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
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
        public void SubsTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = calculatorEngine.Calculate("subtract", number1, number2);
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void SubsTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = calculatorEngine.Calculate("-", number1 , number2);
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void DivsTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = calculatorEngine.Calculate("divide", number1, number2);
            Assert.AreEqual(3, result);

        }
        [TestMethod]
        public void DivsTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = calculatorEngine.Calculate("/", number1 , number2);
            Assert.AreEqual(3, result);
        }

      

        public void MultTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = calculatorEngine.Calculate("multiply", number1, number2);
            Assert.AreEqual(2, result);

        }

        [TestMethod]
        public void MultTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = calculatorEngine.Calculate("*", number1 , number2);
            Assert.AreEqual(2, result);
        }
    }
}