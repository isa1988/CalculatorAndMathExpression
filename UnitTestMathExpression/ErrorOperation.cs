using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMathExpression
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
            MathExpressionWithBrackets.MathExpressionWithBracketsCalc mathExpression = new MathExpressionWithBrackets.MathExpressionWithBracketsCalc();
            string answer = mathExpression.GetResult("8 - 7b * 6 + 4 / 2");
            string answerExp = "В выражение есть лишние символы, которые могут повлечь за собой ошибки при вычисление";
            Assert.AreEqual(answerExp, answer);
        }

    }

}
