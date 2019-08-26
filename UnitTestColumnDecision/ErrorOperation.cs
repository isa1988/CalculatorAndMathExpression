using System;
using ColumnDecision;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestColumnDecision
{
    /// <summary>
    /// Умножение
    /// </summary>
    [TestClass]
    public class ErrorOperation
    {
        [TestMethod]

        public void Calc()
        {
            TaskOne taskOne = new TaskOne();
            string answer = taskOne.GetResult("8 - 7b * 6 + 4 / 2");
            string answerExp = "В выражение есть лишние символы, которые могут повлечь за собой ошибки при вычисление";
            Assert.AreEqual(answerExp, answer);
        }

    }

}
