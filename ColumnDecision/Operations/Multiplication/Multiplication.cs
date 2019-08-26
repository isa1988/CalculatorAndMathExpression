using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ColumnDecision.Helper;

namespace ColumnDecision.Operations.Multiplication
{
    /// <summary>
    /// Умнажение
    /// </summary>
    class Multiplication
    {
        /// <summary>
        /// Произведение
        /// </summary>
        /// <param name="multiplierOne">Первый множитель</param>
        /// <param name="multiplierTwo">Второй множитель</param>
        /// <returns></returns>
        public decimal Composition(decimal multiplierOne, decimal multiplierTwo)
        {
            return multiplierOne * multiplierTwo;
        }

        /// <summary>
        /// Произведение в столбик
        /// </summary>
        /// <param name="multiplierOne">Первый множитель</param>
        /// <param name="multiplierTwo">Второй множитель</param>
        /// <param name="composition">Произведение</param>
        /// <returns></returns>
        public string Composition(decimal multiplierOne, decimal multiplierTwo, ref decimal composition)
        {
            composition = Composition(multiplierOne, multiplierTwo);

            List<decimal> valueList = new List<decimal>();
            valueList.Add(multiplierOne);
            valueList.Add(multiplierTwo);
            decimal value = 0;
            string multiplierTwoStr = multiplierTwo.ToString();
            if (multiplierTwo.ToString().Length > 1)
            {
                for (int i = 0; i < multiplierTwoStr.Length; i++)
                {
                    if (multiplierTwoStr[i] == ',') continue;
                    value = multiplierTwoStr[i] - '0';
                    valueList.Add(value * multiplierOne);
                }
                valueList.Add(multiplierOne * multiplierTwo);

            }
            else
            {
                valueList.Add(multiplierOne * multiplierTwo);
            }

            return GetResult(valueList);
        }

        /// <summary>
        /// Вернуть конечный результат
        /// </summary>
        /// <param name="array">Прорешенный массив</param>
        /// <returns></returns>
        private string GetResult(List<decimal> array)
        {
            string[] arrayStrList = GetArrayStr(array);
            
            return GetResult(arrayStrList);
        }

        /// <summary>
        /// Обработка данных вернуть результат
        /// </summary>
        /// <param name="arrayStrList">Прорешенный массив</param>
        /// <returns></returns>
        private string GetResult(string[] arrayStrList)
        {
            int count = arrayStrList.Length == 3 ? 1 : 2;
            int maxLength = arrayStrList.GetMaxLength() + 1;
            string[,] arrayStrListHelper = GetStrListHelper(arrayStrList, maxLength, count);

            StringBuilder buffer = new StringBuilder();

            for (int i = 0; i < arrayStrList.Length; i++)
            {
                for (int j = 0; j < maxLength; j++)
                {
                    buffer.Append(arrayStrListHelper[i, j]?.ToString());
                }

                if (count == 1)
                {
                    if (i == 1)
                    {
                        buffer.Append(Environment.NewLine);
                        buffer.Append(new string('_', maxLength));
                    }
                }
                else
                {
                    if (i == 1 || i == arrayStrList.Length - 2)
                    {
                        buffer.Append(Environment.NewLine);
                        buffer.Append(new string('_', maxLength));
                    }
                }

                buffer.Append(Environment.NewLine);
            }

            return buffer.ToString();
        }

        /// <summary>
        /// Собрать данные в матричном виде
        /// </summary>
        /// <param name="arrayStrList"></param>
        /// <param name="maxLength"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        private string[,] GetStrListHelper(string[] arrayStrList, int maxLength, int count)
        {
            int index = 0, indexIndentRigth = 1;
            string line = "";
            int indexSign = 1;
            bool isCheckSign = false;
            string sign = "x";
            string[,] arrayStrListHelper = new string[arrayStrList.Length, maxLength];
            for (int i = 0; i < arrayStrList.Length; i++)
            {
                line = arrayStrList[i].Trim();
                index = line.Length;

                if (count == 2 && i > 2)
                {
                    if (!isCheckSign)
                    {
                        indexSign = ((arrayStrList.Length - 1 - 2) / 2) + 2;
                        isCheckSign = true;
                        sign = "+";
                    }
                    indexIndentRigth++;
                    if (i == arrayStrList.Length - 1) indexIndentRigth = 1;
                }
                for (int j = maxLength - indexIndentRigth; j >= 0; j--)
                {
                    index--;
                    if (j == 0 && (indexSign == i || indexSign == arrayStrList.Length - 1))
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
        /// Преобразование в строчный массив
        /// </summary>
        /// <param name="array">Прорешенный массив</param>
        /// <returns></returns>
        private string[] GetArrayStr(List<decimal> array)
        {
            string[] arrayStrList = new string[array.Count];
            string line = string.Empty;
            for (int i = 0; i < array.Count; i++)
            {
                if (i > 2 && array.Count != 3)
                {
                    line += " ";
                    if (i == array.Count - 1)
                    {
                        line = string.Empty;
                    }
                }
                arrayStrList[i] = array[i].ToString() + line;
            }
            return arrayStrList;
        }
    }
}
