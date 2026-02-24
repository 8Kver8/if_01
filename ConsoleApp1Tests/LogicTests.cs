using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void TestHaveFirstDigit()
        {
            int num = 45;
            int digit = 4;
            string actual = Logic.CheckDigit(num, digit);
            Assert.AreEqual("такая цифра есть", actual);
        }

        [TestMethod()]
        public void TestHaveSecondDigit()
        {
            int num = 45;
            int digit = 5;
            string actual = Logic.CheckDigit(num, digit);
            Assert.AreEqual("такая цифра есть", actual);
        }

        [TestMethod()]
        public void TestHaveNotPositiveDigit()
        {
            int num = 45;
            int digit = 3;
            string actual = Logic.CheckDigit(num, digit);
            Assert.AreEqual("такой цифры нет", actual);
        }

        [TestMethod()]
        public void TestHaveAllDigit()
        {
            int num = 44;
            int digit = 4;
            string actual = Logic.CheckDigit(num, digit);
            Assert.AreEqual("такая цифра есть", actual);
        }

        [TestMethod()]
        public void TestHaveNotNegativeDigit()
        {
            int num = 45;
            int digit = -5;
            string actual = Logic.CheckDigit(num, digit);
            Assert.AreEqual("такой цифры нет", actual);
        }

        [TestMethod()]
        public void TestHaveNotNumber()
        {
            int num = 45;
            int digit = 10;
            string actual = Logic.CheckDigit(num, digit);
            Assert.AreEqual("такой цифры нет", actual);
        }
    }
}