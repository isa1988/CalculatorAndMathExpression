using System;
using ColumnDecision;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestColumnDecision
{
    /// <summary>
    /// Умножение
    /// </summary>
    [TestClass]
    public class MultiplicationOperation
    {
        [TestMethod]

        public void Calc()
        {
            TaskOne taskOne = new TaskOne();
            string answer = taskOne.GetResult("22,67 * 4,5");
            string answerExp = "   22,67" + Environment.NewLine +
                               "x    4,5" + Environment.NewLine +
                               "________" + Environment.NewLine +
                               "   90,68" + Environment.NewLine +
                               "+113,35" + Environment.NewLine +
                               "________" + Environment.NewLine +
                               " 102,015" + Environment.NewLine + Environment.NewLine;
            Assert.AreEqual(answerExp, answer);
        }

    }

}
