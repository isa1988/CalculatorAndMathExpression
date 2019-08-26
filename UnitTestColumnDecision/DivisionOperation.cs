using System;
using ColumnDecision;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestColumnDecision
{
    /// <summary>
    /// Деление
    /// </summary>
    [TestClass]
    public class DivisionOperation
    {
        [TestMethod]

        public void Calc()
        {
            TaskOne taskOne = new TaskOne();
            string answer = taskOne.GetResult("22,67 / 4,5");
            string answerExp = "2267|450" + Environment.NewLine +
                               "2250|_______" + Environment.NewLine +
                               "____|5,03(7)" + Environment.NewLine +
                               "  1700" + Environment.NewLine +
                               "  1350" + Environment.NewLine +
                               "  ____" + Environment.NewLine +
                               "   3500" + Environment.NewLine +
                               "   3150" + Environment.NewLine +
                               "   ____" + Environment.NewLine +
                               "    3500" + Environment.NewLine + Environment.NewLine;
            Assert.AreEqual(answerExp, answer);
        }

    }

}
