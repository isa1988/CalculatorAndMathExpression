using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMathExpression
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
            MathExpressionWithBrackets.MathExpressionWithBracketsCalc mathExpression = new MathExpressionWithBrackets.MathExpressionWithBracketsCalc();
            string answer = mathExpression.GetResult("22,67 + 4,5");
            string answerExp = "Ваш ответ 27,17 " + Environment.NewLine +
                               " Действие 1, 22,67 + 4,5" + Environment.NewLine +
                               " 22,67" + Environment.NewLine +
                               "+  4,5" + Environment.NewLine +
                               "______" + Environment.NewLine +
                               " 27,17" + Environment.NewLine;
            Assert.AreEqual(answerExp, answer);
        }
    }
}
