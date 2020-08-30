using System;
using MathExpression;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMathExpression
{
    /// <summary>
    /// Умножение
    /// </summary>
    [TestClass]
    public class AllOperations
    {
        [TestMethod]

        public void Calc()
        {
            TaskOne taskOne = new TaskOne();
            string answer = taskOne.GetResult("8 - 7 * 6 + 4 / 2");
            string answerExp = "Ответ -32" + Environment.NewLine +
                               "Действие 1 7 * 6" + Environment.NewLine +
                               "  7" + Environment.NewLine +
                               "x 6" + Environment.NewLine +
                               "___" + Environment.NewLine +
                               " 42" + Environment.NewLine +
                               Environment.NewLine +
                               "Действие 2 4 / 2" + Environment.NewLine +
                               "4|2" + Environment.NewLine +
                               "4|_" + Environment.NewLine +
                               "_|2" + Environment.NewLine +
                               "0" + Environment.NewLine +
                               Environment.NewLine +
                               "Действие 3 8 - 42" + Environment.NewLine +
                               "   8" + Environment.NewLine +
                               "- 42" + Environment.NewLine +
                               "____" + Environment.NewLine +
                               " -34" + Environment.NewLine +
                               Environment.NewLine +
                               "Действие 4 -34 + 2" + Environment.NewLine +
                               " -34" + Environment.NewLine +
                               "+  2" + Environment.NewLine +
                               "____" + Environment.NewLine +
                               " -32" + Environment.NewLine + Environment.NewLine;
            Assert.AreEqual(answerExp, answer);
        }

    }

}
