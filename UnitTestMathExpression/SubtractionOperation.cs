using System;
using MathExpression;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMathExpression
{
    /// <summary>
    /// Вычитание
    /// </summary>
    [TestClass]
    public class SubtractionOperation
    {
        [TestMethod]

        public void Calc()
        {
            TaskOne taskOne = new TaskOne();
            string answer = taskOne.GetResult("22,67 - 4,5");
            string answerExp = " 22,67" + Environment.NewLine +
                               "-  4,5" + Environment.NewLine +
                               "______" + Environment.NewLine +
                               " 18,17" + Environment.NewLine + Environment.NewLine;
            Assert.AreEqual(answerExp, answer);
        }

    }

}
