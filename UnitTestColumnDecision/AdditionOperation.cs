using System;
using ColumnDecision;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestColumnDecision
{
    /// <summary>
    /// Сложение
    /// </summary>
    [TestClass]
    public class AdditionOperation
    {
        [TestMethod]
        public void Calc()
        {
            TaskOne taskOne = new TaskOne();
            string answer = taskOne.GetResult("22,67 + 4,5");
            string answerExp = " 22,67" + Environment.NewLine +
                               "+  4,5" + Environment.NewLine +
                               "______" + Environment.NewLine +
                               " 27,17" + Environment.NewLine + Environment.NewLine;
            Assert.AreEqual(answerExp, answer);
        }
    }
}
