using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathExpression.Helper;

namespace MathExpression.Operations.AdditionSubtraction
{
    /// <summary>
    /// Общие методы можду сложением и вычитанием
    /// </summary>
    abstract class AdditionSubtraction
    {
        /// <summary>
        /// Сложение или вычитание реение в столбик
        /// </summary>
        /// <param name="termOne">Первый аргумент</param>
        /// <param name="termTwo">Второй аргумент</param>
        /// <param name="sum">Результат выражения</param>
        /// <param name="sign">Плюс или минус</param>
        /// <returns></returns>
        protected string GetValue(decimal termOne, decimal termTwo, decimal sum, string sign)
        {
            StringBuilder line = new StringBuilder(string.Empty);
            string[] arrayStr = GetArrayToStr(new[] { termOne, termTwo, sum });

            return GetResult(arrayStr, sign);
        }

        /// <summary>
        /// Результат
        /// </summary>
        /// <param name="arrayStrList">Прорешенный массив</param>
        /// <param name="sign">Математический знак </param>
        /// <returns></returns>
        private string GetResult(string[] arrayStrList, string sign)
        {
            int maxLength = arrayStrList.GetMaxLength() + 1;
            string[,] arrayStrListHelper = GetStrListHelper(arrayStrList, maxLength, sign);

            StringBuilder buffer = new StringBuilder();

            for (int i = 0; i < arrayStrList.Length; i++)
            {
                for (int j = 0; j < maxLength; j++)
                {
                    buffer.Append(arrayStrListHelper[i, j]?.ToString());
                }
                if (i == 1)
                {
                    buffer.Append(Environment.NewLine);
                    buffer.Append(new string('_', maxLength));
                }

                buffer.Append(Environment.NewLine);
            }

            return buffer.ToString();
        }

        /// <summary>
        /// Собрать данные в матричном виде
        /// </summary>
        /// <param name="arrayStrList">Прорешенный массив</param>
        /// <param name="maxLength">Максимальная строка в массиве</param>
        /// <param name="sign">Знак математического действия</param>
        /// <returns></returns>
        private string[,] GetStrListHelper(string[] arrayStrList, int maxLength, string sign)
        {
            int index = 0, indexIndentRigth = 1;
            string line = "";
            string[,] arrayStrListHelper = new string[arrayStrList.Length, maxLength];
            for (int i = 0; i < arrayStrList.Length; i++)
            {
                line = arrayStrList[i].Trim();
                index = line.Length;

                for (int j = maxLength - indexIndentRigth; j >= 0; j--)
                {
                    index--;
                    if (j == 0 && i == 1)
                    {
                        arrayStrListHelper[i, j] = sign;
                        break;
                    }
                    arrayStrListHelper[i, j] = (index > -1) ? line[index].ToString() : " ";
                }
            }

            return arrayStrListHelper;
        }

        /// <summary>
        /// Преобразоние из числового в строчное представление в столбик
        /// </summary>
        /// <param name="args">Аргументы</param>
        /// <returns></returns>
        private string[] GetArrayToStr(decimal[] args) => args.Select(x => x.ToString()).ToArray();
    }
}
