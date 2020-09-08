using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressionCalcLogice.Helper
{
    public static class ClassHelper
    {
        /// <summary>
        /// Максимум в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <returns></returns>
        public static int GetMaxLength(this string[] array) => array.Max(x => x.Length);
    }
}
