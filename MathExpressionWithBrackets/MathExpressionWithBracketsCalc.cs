using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathExpressionCalcLogice.Operations;

namespace MathExpressionWithBrackets
{
    public class MathExpressionWithBracketsCalc
    {
        /// <summary>
        /// Аргументы в выражение
        /// </summary>
        List<string> arguments = new List<string>();

        Dictionary<string, byte> operationPrioritys = new Dictionary<string, byte>();

        Operation operation;

        public MathExpressionWithBracketsCalc()
        {
            operationPrioritys.Add("*", (byte)Priority.MultiplicationAndDivision);
            operationPrioritys.Add("/", (byte)Priority.MultiplicationAndDivision);
            operationPrioritys.Add("+", (byte)Priority.AdditionAndSubtraction);
            operationPrioritys.Add("-", (byte)Priority.AdditionAndSubtraction);
            operation = new Operation();
        }

        /// <summary>
        /// Вычисление
        /// </summary>
        /// <param name="value">Математическое выражение</param>
        public string GetResult(string value)
        {
            value = value.Replace(".", ",");
            arguments = new List<string>();
            SetArray(value);
            var result = GetResult();
            return result;
        }

        private string GetResult()
        {
            StringBuilder resultME = new StringBuilder(string.Empty);
            int numAction = 0;
            var priority = Priority.AdditionAndSubtraction;
            var numberList = new List<decimal>();
            var operationList = new List<string>();
            decimal result = 0;
            foreach (string rec in arguments)
            {
                if (string.IsNullOrWhiteSpace(rec))
                    continue;
                if (rec == "-" || rec == "+" ||
                    rec == "*" || rec == "/")
                {
                    priority = (Priority) operationPrioritys[rec];
                    Calculate(rec);
                }
                else if (rec == "(" || rec == ")")
                {
                    Calculate(rec);
                }
                else
                {
                    numberList.Add(decimal.Parse(rec));
                }

            }

            Calculate("", true);

            return $"Ваш ответ {result} {Environment.NewLine} {resultME.ToString()}";
        

            void Calculate(string operationName, bool isLast = false)
            {
                if (!isLast)
                {
                    if (operationName == ")")
                    {
                        CheckMultiplicationAndDivision();
                        AnalysisBrackets();
                        return;
                    }
                    else if (operationName == "(")
                    {
                        operationList.Add(operationName);
                        return;
                    }
                    CheckMultiplicationAndDivision();
                    operationList.Add(operationName);
                }

                else
                {
                    CheckMultiplicationAndDivision();
                    while (operationList.Count > 0)
                    {
                        CalcValue(operationList.Count);
                    }
                }

                void CheckMultiplicationAndDivision()
                {
                    if (operationList.Count == 0 || operationList[operationList.Count -1] == "-" || 
                        operationList[operationList.Count - 1] == "+" || operationList[operationList.Count - 1] == "(")
                        return;
                    CalcValue(1);
                }
            }

            void AnalysisBrackets()
            {
                int lasIndex = 0;
                for (int i = operationList.Count-1; i >= 0; i--)
                {
                    lasIndex++;
                    if (operationList[i] == "(")
                    {
                        break;
                    }
                }

                operationList.RemoveAt(operationList.Count - lasIndex);
                lasIndex--;

                while (lasIndex > 0)
                {
                    CalcValue(lasIndex);
                    lasIndex--;
                }
            }

            void CalcValue(int index)
            {
                resultME.Append(GetNameOperation(index) + Environment.NewLine);
                resultME.Append(GetResult(operationList[operationList.Count - index],
                    numberList[numberList.Count - (index + 1)],
                    numberList[numberList.Count - index], ref result));
                operationList.RemoveAt(operationList.Count - index);
                numberList[numberList.Count - index] = result;
                numberList.RemoveAt(numberList.Count - (index + 1));
            }

            string GetNameOperation(int index)
            {
                numAction++;
                return "Действие " + numAction.ToString() +
                       ", " + numberList[numberList.Count - (index + 1)] +
                       " " + operationList[operationList.Count - index] +
                       " " + numberList[numberList.Count - index];
            }
        }

        private string GetResult(string operationName, decimal valueOne, decimal valueTwo, ref decimal result)
        {
            return operation.Calc(operationName, valueOne, valueTwo, ref result);
        }



        /// <summary>
        /// заполнение массивов аргуметов и операций
        /// </summary>
        /// <param name="value">Математическое выражение</param>
        private void SetArray(string value)
        {
            var number = new StringBuilder(string.Empty);
            var line = string.Empty;
            value = value.Trim();
            for (int i = 0; i < value.Length; i++)
            {
                line = value[i].ToString();
                if (line == " " || line == "") continue;

                if (i == 0)
                {
                    number.Append(line);
                    continue;
                }

                if (line == "-" || line == "+" ||
                    line == "*" || line == "/" ||
                    line == "(" || line == ")")
                {
                    if (number.ToString() != string.Empty)
                        arguments.Add(number.ToString());
                    arguments.Add(line);
                    number = new StringBuilder(string.Empty);
                    continue;
                }

                number.Append(line);
            }
            arguments.Add(number.ToString());
        }

    }
}
