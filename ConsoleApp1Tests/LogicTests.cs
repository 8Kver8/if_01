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
        public void Test1()
        {
            int num = 45;
            int digit = 4;
            string expected = "такая цифра есть";
            string actual = Logic.CheckDigit(num, digit);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test2()
        {
            int num = 45;
            int digit = 5;
            string expected = "такая цифра есть";
            string actual = Logic.CheckDigit(num, digit);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test3()
        {
            int num = 45;
            int digit = 3;
            string expected = "такой цифры нет";
            string actual = Logic.CheckDigit(num, digit);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test4()
        {
            int num = 44;
            int digit = 4;
            string expected = "такая цифра есть";
            string actual = Logic.CheckDigit(num, digit);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test5()
        {
            int num = 45;
            int digit = -5;
            string expected = "такой цифры нет";
            string actual = Logic.CheckDigit(num, digit);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test6()
        {
            int num = 45;
            int digit = 10;
            string expected = "такой цифры нет";
            string actual = Logic.CheckDigit(num, digit);
            Assert.AreEqual(expected, actual);
        }
    }
}