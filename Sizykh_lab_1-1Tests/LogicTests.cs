using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sizykh_lab_1_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sizykh_lab_1_1.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void NumberIsNotLucky()
        {
            int number = 125186;
            var message = Logic.IsLucky(number);
            Assert.AreEqual("Обычное число", message);
        }
        [TestMethod()]
        public void NumberIsLucky()
        {
            int number = 541235;
            var message = Logic.IsLucky(number);
            Assert.AreEqual("Счастливое число", message);
        }
        [TestMethod()]
        public void NumberIsNot6digits()
        {
            int number = 123;
            var message = Logic.IsLucky(number);
            Assert.AreEqual("Число не шестизначное", message);
        }
    }
}