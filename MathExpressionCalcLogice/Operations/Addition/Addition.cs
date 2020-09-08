using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressionCalcLogice.Operations.Addition
{
    /// <summary>
    /// Сложение
    /// </summary>
    class Addition : AdditionSubtraction.AdditionSubtraction
    {
        /// <summary>
        /// Сумма
        /// </summary>
        /// <param name="termOne">Первое слагаемое</param>
        /// <param name="termTwo">Второе слагаемое</param>
        /// <returns></returns>
        public decimal Sum(decimal termOne, decimal termTwo)
        {
            return termOne + termTwo;
        }

        /// <summary>
        /// Сумма в столбик
        /// </summary>
        /// <param name="termOne">Первое слагоемое</param>
        /// <param name="termTwo">Второе слагаемое</param>
        /// <param name="sum">Сумма</param>
        /// <returns></returns>
        public string Sum(decimal termOne, decimal termTwo, ref decimal sum)
        {
            sum = Sum(termOne, termTwo);

            return GetValue(termOne, termTwo, sum, "+");
        }
    }
}
