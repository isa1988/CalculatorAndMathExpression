using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMathExpression
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
            MathExpressionWithBrackets.MathExpressionWithBracketsCalc mathExpression = new MathExpressionWithBrackets.MathExpressionWithBracketsCalc();
            string answer = mathExpression.GetResult("22,67 / 4,5");
            string answerExp = "Ваш ответ 5,03777778 " + Environment.NewLine +
                               " Действие 1, 22,67 / 4,5" + Environment.NewLine +
                               "2267|450" + Environment.NewLine + 
                               "2250|_______" + Environment.NewLine +
                               "____|5,03(7)" + Environment.NewLine +
                               "  1700" + Environment.NewLine +
                               "  1350" + Environment.NewLine +
                               "  ____" + Environment.NewLine +
                               "   3500" + Environment.NewLine +
                               "   3150" + Environment.NewLine +
                               "   ____" + Environment.NewLine +
                               "    3500" + Environment.NewLine;
            Assert.AreEqual(answerExp, answer);
        }

    }

}
