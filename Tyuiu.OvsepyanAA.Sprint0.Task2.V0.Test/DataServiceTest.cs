using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.OvsepyanAA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.OvsepyanAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMessangeValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Арам";
            var res = DataService.GetMessage(name);

            //Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет, Арам", res);
        }
    }
}
