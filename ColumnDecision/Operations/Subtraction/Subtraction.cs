using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumnDecision.Operations.Subtraction
{
    /// <summary>
    /// Вычитание
    /// </summary>
    class Subtraction : AdditionSubtraction.AdditionSubtraction
    {
        /// <summary>
        /// Разностть
        /// </summary>
        /// <param name="subtrahend">Вычитаемое</param>
        /// <param name="subtractor">Вычиталь</param>
        /// <returns></returns>
        public decimal Difference(decimal subtrahend, decimal subtractor)
        {
            return subtrahend - subtractor;
        }

        /// <summary>
        /// Сумма в столбик
        /// </summary>
        /// <param name="termOne">Первое слагоемое</param>
        /// <param name="termTwo">Второе слагаемое</param>
        /// <param name="sum">Сумма</param>
        /// <returns></returns>
        public string Difference(decimal subtrahend, decimal subtractor, ref decimal difference)
        {
            difference = Difference(subtrahend, subtractor);

            return GetValue(subtrahend, subtractor, difference, "-");
        }
    }
}
