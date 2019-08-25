using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumnDecision.Helper
{
    public static class ClassHelper
    {
        /// <summary>
        /// Максимум в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <returns></returns>
        public static int GetMaxLength(this string[] array)
        {
            List<int> lstNumber = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                lstNumber.Add(array[i].Length);
            }

            return lstNumber.Max();
        }
    }
}
