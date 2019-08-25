using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumnDecision.Operations.AdditionSubtraction
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
            int maxLength = GetMaxLine(new[] { termOne, termTwo, sum });
            string[] arrayStr = GetArrayToStr(new[] { termOne, termTwo, sum }, sign);

            StringBuilder[] lstLine = new StringBuilder[arrayStr.Count()];
            for (int i = 0; i < lstLine.Count(); i++)
            {
                lstLine[i] = new StringBuilder(arrayStr[i]);
            }
            int countReplay = 0;
            string preValue = string.Empty;
            for (int i = 0; i < lstLine.Count(); i++)
            {
                if (lstLine[i].ToString().Trim().Length != maxLength)
                {
                    preValue = lstLine[i].ToString();
                    countReplay = maxLength - preValue.Trim().Length;
                    if (countReplay > 0)
                    {
                        lstLine[i] = new StringBuilder(new string(' ', countReplay));
                        lstLine[i].Append(preValue);
                    }
                }
                line.Append(lstLine[i] + Environment.NewLine);
            }
            return line.ToString();
        }

        /// <summary>
        /// Вернуть максимальное число в строке
        /// </summary>
        /// <param name="args">Аргументы</param>
        /// <returns></returns>
        private int GetMaxLine(decimal[] args)
        {
            int[] maxLength = new int[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                if (i == 1)
                {
                    if (args[i].ToString().Length == args[i - 1].ToString().Length &&
                        args[i + 1].ToString().Length == args[i - 1].ToString().Length &&
                        args[i].ToString().Length == args[i + 1].ToString().Length)
                        maxLength[i] = args[i].ToString().Length + 1;
                    else
                        maxLength[i] = args[i].ToString().Length + 1;
                    continue;
                }
                maxLength[i] = args[i].ToString().Length;
            }
            return maxLength.Max();
        }

        /// <summary>
        /// Преобразоние из числового в строчное представление в столбик
        /// </summary>
        /// <param name="args">Аргументы</param>
        /// <param name="sign">Знак плюс или минус</param>
        /// <returns></returns>
        private string[] GetArrayToStr(decimal[] args, string sign)
        {
            string[] arayLine = new string[args.Length + 1];
            int countDifference = 0;
            for (int i = 0; i < arayLine.Length; i++)
            {
                if (i == 1)
                {
                    countDifference = args[i - 1].ToString().Length - args[i].ToString().Length;
                    if (countDifference > 0)
                    {
                        //countDifference++;
                        arayLine[i] = sign + new string(' ', countDifference) + args[i].ToString();
                        arayLine[i - 1] = " " + arayLine[i - 1];
                    }
                    else
                    {
                        arayLine[i] = sign + args[i].ToString();
                        countDifference = Math.Abs(countDifference);
                    }

                    i++;
                    arayLine[i] = new string(' ', countDifference > 0 ? 1 : 0) + new string('_', GetMaxLine(args));
                    continue;
                }
                if (args.Length > i)
                    arayLine[i] = args[i].ToString();
                else
                    arayLine[i] = new string(' ', countDifference > 0 ? 1 : 0) + args[i - 1].ToString();
            }

            return arayLine;
        }
    }
}
