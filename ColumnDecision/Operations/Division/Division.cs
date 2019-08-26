using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumnDecision.Operations.Division
{
    /// <summary>
    /// Деление
    /// </summary>
    class Division
    {
        /// <summary>
        /// Частное
        /// </summary>
        /// <param name="dividend">Делимое</param>
        /// <param name="divider">Делитель</param>
        /// <returns></returns>
        public decimal Quotient(decimal dividend, decimal divider)
        {
            return (divider != 0) ? dividend / divider : 0;
        }

        /// <summary>
        /// Частное в столбик
        /// </summary>
        /// <param name="dividend">Делимое</param>
        /// <param name="divider">Делитель</param>
        /// <param name="quotient">частное</param>
        /// <returns></returns>
        public string Quotient(decimal dividend, decimal divider, ref decimal quotient)
        {
            quotient = Quotient(dividend, divider);
            if ((quotient % 1).ToString().Length > 8) quotient = (decimal) Math.Round(quotient, 8);
            if (divider == 0) return "На ноль делить нельзя";
            
            string power = (dividend % 1).ToString().Length > (divider % 1).ToString().Length 
                            ? (dividend % 1).ToString()
                            : (divider % 1).ToString();
            power = power.Replace("0,", string.Empty);
            StringBuilder answer = new StringBuilder(string.Empty);
            if (power != "0" && power.Length > 0)
            {
                dividend *= (decimal) Math.Pow(10,  power.Length);
                divider *= (decimal) Math.Pow(10, power.Length);
            }


            List<DivisionHelper> valueList = GetDivisionHelperList(quotient, (int) dividend, (int) divider, ref answer);

            return GetResult(valueList, divider, answer.ToString());
        }

        /// <summary>
        /// Возрат прорешеннго массива
        /// </summary>
        /// <param name="quotient">Конечный ответ</param>
        /// <param name="dividendImt">Делимое</param>
        /// <param name="dividerInt">Делитель</param>
        /// <param name="answer">Ответ в человеском представление</param>
        /// <returns></returns>
        private List<DivisionHelper> GetDivisionHelperList(decimal quotient, int dividendImt, int dividerInt,
                                                           ref StringBuilder answer)
        {
            string quotientStr = quotient.ToString();
            int value = 0, transformedValue = 0, preValue = 0, composition = 0;

            transformedValue = GetTransformedValue(dividendImt, dividerInt);
            List<DivisionHelper> valueList = new List<DivisionHelper>();
            valueList.Add(new DivisionHelper(dividendImt, transformedValue));
            //valueList.Add(new DivisionHelper(divider, divider));
            for (int i = 0; i < quotientStr.Length; i++)
            {
                answer.Append(quotientStr[i].ToString());
                if (quotientStr[i].ToString() == "," || quotientStr[i].ToString() == "0") continue;
                composition = dividerInt * int.Parse(quotientStr[i].ToString());
                value = transformedValue - composition;
                transformedValue = GetTransformedValue(value, dividerInt);
                if (value == 0)
                {
                    valueList.Add(new DivisionHelper(composition, composition));
                    valueList.Add(new DivisionHelper(value, transformedValue));
                    break;
                }
                else if (value == preValue)
                {
                    string answeHelper = answer.ToString().Substring(0, answer.ToString().Length - 1) + "(" +
                                         answer.ToString().Substring(answer.ToString().Length - 1, 1) + ")";
                    answer = new StringBuilder(answeHelper);
                    valueList.Add(new DivisionHelper(composition, composition));
                    valueList.Add(new DivisionHelper(value, transformedValue));
                    break;
                }

                preValue = value;
                valueList.Add(new DivisionHelper(composition, composition));
                valueList.Add(new DivisionHelper(value, transformedValue));
            }

            return valueList;
        }

        /// <summary>
        /// Добавить нолики к числу если оно меньше делителя
        /// </summary>
        /// <param name="value">Число</param>
        /// <param name="divider">Делитель</param>
        /// <returns></returns>
        private int GetTransformedValue(int value, int divider)
        {
            if (value == 0) return value;
            while (value < divider)
            {
                value *= 10;
            }

            return value;
        }

        /// <summary>
        /// Вернуть конечный результат
        /// </summary>
        /// <param name="array">Прорешенный массив</param>
        /// <returns></returns>
        private string GetResult(List<DivisionHelper> array, decimal divider, string answer)
        {
            int countArray = (array.Count / 2) + array.Count;
            StringBuilder[] arrayStrList = new StringBuilder[countArray];
            StringBuilder line = new StringBuilder(string.Empty);
            
            string oldDividend = string.Empty;
            int indexArrayStrList = 0;
            for (int i = 0; i < array.Count; i++)
            {
                if (i != 0)
                {
                    line = GetPushSpace(line, oldDividend, array[i].ReceivedValue.ToString("0"));
                }

                arrayStrList[indexArrayStrList] = 
                    new StringBuilder(GetValueAnswerAction(array[i].TransformedValue.ToString("0"),
                        divider.ToString("0"), answer, line.ToString(), i));
                
                if (i != 0 && i % 2 > 0)
                {
                    indexArrayStrList++;
                    arrayStrList[indexArrayStrList] = new StringBuilder(
                                           GetSignEqually(oldDividend, array[i].ReceivedValue.ToString(), 
                                           line.ToString(), answer, i));
                }

                indexArrayStrList++;
                oldDividend = array[i].TransformedValue.ToString();
            }
            
            return GetResult(arrayStrList);
        }

        /// <summary>
        /// Вспомогательная ф-ия на шаге возращает правильную строку со всеми отступами 
        /// </summary>
        /// <param name="transformedValue">Значение</param>
        /// <param name="divider">Делитель</param>
        /// <param name="answer">Ответ</param>
        /// <param name="line">Отспупы</param>
        /// <param name="i">Итерация</param>
        /// <returns></returns>
        private string GetValueAnswerAction(string transformedValue, string divider, string answer, string line, int i)
        {
            string retVal = line + transformedValue;
            if (i < 2)
            {
                switch (i)
                {
                    case 0:
                    {
                        retVal += "|" + divider;
                        break;
                    }
                    case 1:
                    {
                        int countSpace = answer.Length > divider.ToString().Length
                            ? answer.Length
                            : divider.ToString().Length;
                        retVal += "|" + new string('_', countSpace);
                        break;
                    }
                }
            }

            return retVal;
        }

        /// <summary>
        /// Поставить знак равно 
        /// </summary>
        /// <param name="oldDividend">Прежнее значение</param>
        /// <param name="receivedValue">Ответ разность</param>
        /// <param name="line">Отступы</param>
        /// <param name="answer">Ответ</param>
        /// <param name="i">Итерация</param>
        /// <returns></returns>
        private string GetSignEqually(string oldDividend, string receivedValue, string line, string answer, int i)
        {
            int countSpace = oldDividend.Length > receivedValue.Length
                ? oldDividend.Length
                : receivedValue.Length;
            string lineRet = line.ToString() + new string('_', countSpace);
            if (i == 1)
            {
                lineRet +="|" + answer;
            }

            return lineRet;
        }

        /// <summary>
        /// Вспомогательная ф-ия готовит ответ по готовому списку
        /// </summary>
        /// <param name="arrayStrList">Готовый список</param>
        /// <returns></returns>
        private string GetResult(StringBuilder[] arrayStrList)
        {
            StringBuilder line = new StringBuilder(string.Empty);
            for (int i = 0; i < arrayStrList.Length; i++)
            {
                line.Append(arrayStrList[i].ToString() + Environment.NewLine);
            }

            return line.ToString();
        }

        /// <summary>
        /// Отступы слева
        /// </summary>
        /// <param name="value">Хранилище отступов</param>
        /// <param name="oldDividend">Предыдущее значение</param>
        /// <param name="dividend">Делимое</param>
        /// <returns></returns>
        private StringBuilder GetPushSpace(StringBuilder value, string oldDividend, string dividend)
        {
            int countSpace = Math.Abs(oldDividend.Length - dividend.Length);
            value.Append(new string(' ', countSpace));
            return value;
        }
    }
}
