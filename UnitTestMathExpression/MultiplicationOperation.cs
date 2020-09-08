using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMathExpression
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
            MathExpressionWithBrackets.MathExpressionWithBracketsCalc mathExpression = new MathExpressionWithBrackets.MathExpressionWithBracketsCalc();
            string answer = mathExpression.GetResult("22,67 * 4,5");
            string answerExp = "Ваш ответ 102,015 "+Environment.NewLine+
                               " Действие 1, 22,67 * 4,5"+Environment.NewLine+
                               "   22,67" + Environment.NewLine +
                               "x    4,5" + Environment.NewLine +
                               "________" + Environment.NewLine +
                               "   90,68" + Environment.NewLine +
                               "+113,35" + Environment.NewLine +
                               "________" + Environment.NewLine +
                               " 102,015" + Environment.NewLine;
            Assert.AreEqual(answerExp, answer);
        }

    }

}
