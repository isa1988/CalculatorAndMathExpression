using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumnDecision.Operations
{
    /// <summary>
    /// Операции вычислений
    /// </summary>
    interface ICalc
    {
        /// <summary>
        /// Решить и вернуть значение в столбик
        /// </summary>
        /// <param name="argumetOne">Первый аргумент в выражение</param>
        /// <param name="argumetTwo">Второй аргумент в выражение</param>
        /// <param name="result">Числовой результат</param>
        /// <returns></returns>
        string Calc(decimal argumetOne, decimal argumetTwo, ref decimal result);

        /// <summary>
        /// Решение математической операции
        /// </summary>
        /// <param name="argumetOne">Первое значение</param>
        /// <param name="argumetTwo">Второе значение</param>
        /// <returns></returns>
        decimal Calc(decimal argumetOne, decimal argumetTwo);
    }
}
