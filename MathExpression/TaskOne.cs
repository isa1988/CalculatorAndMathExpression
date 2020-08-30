using MathExpression.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathExpression.Operations.Addition;
using MathExpression.Operations.Division;
using MathExpression.Operations.Multiplication;
using MathExpression.Operations.Subtraction;

namespace MathExpression
{
    /// <summary>
    /// Вычисление
    /// </summary>
    public class TaskOne
    {
        /// <summary>
        /// Аргументы в выражение
        /// </summary>
        List<StringBuilder> arguments = new List<StringBuilder>();
        /// <summary>
        /// Операции в выражение
        /// </summary>
        List<PrioritySpecionForOperation> operations = new List<PrioritySpecionForOperation>();

        Operation operation = new Operation();
        public TaskOne()
        {
            operation.SetCommand((int)OperationType.Multiplication, new MultiplicationCalc());
            operation.SetCommand((int)OperationType.Division, new DivisionCalc());
            operation.SetCommand((int)OperationType.Addition, new AdditionCalc());
            operation.SetCommand((int)OperationType.Subtraction, new SubtractionCalc());
        }

        /// <summary>
        /// Вычисление
        /// </summary>
        /// <param name="value">Математическое выражение</param>
        public string GetResult(string value)
        {
            value = value.Replace(".", ",");
            if (!CheckExpression(value))
            {
                return "В выражение есть лишние символы, которые могут повлечь за собой ошибки при вычисление";
            }
            arguments = new List<StringBuilder>();
            operations = new List<PrioritySpecionForOperation>();
            SetArray(value);
            SetOrder();
            return GetResult();
        }

        private bool CheckExpression(string value)
        {
            string[] chekArray = new string[16];
            for (int i = 0; i < 10; i++)
            {
                chekArray[i] = i.ToString();
            }

            chekArray[10] = ",";
            chekArray[11] = "*";
            chekArray[12] = "/";
            chekArray[13] = "+";
            chekArray[14] = "-";
            chekArray[15] = " ";

            for (int i = 0; i < chekArray.Length; i++)
            {
                value = value.Replace(chekArray[i], string.Empty);
            }

            return value == string.Empty;
        }

        /// <summary>
        /// заполнение массивов аргуметов и операций
        /// </summary>
        /// <param name="value">Математическое выражение</param>
        private void SetArray(string value)
        {
            StringBuilder number = new StringBuilder(string.Empty);
            int index = 0;
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i].ToString() == " ") continue;
                if (i == 0 && value[i].ToString() == "-")
                {
                    operations.Add(new PrioritySpecionForOperation("-", 0, 0, -1));
                    continue;
                }

                if (value[i].ToString() == "-" || value[i].ToString() == "+" ||
                    value[i].ToString() == "*" || value[i].ToString() == "/")
                {
                    if (number.ToString() != string.Empty)
                        arguments.Add(number);
                    number = new StringBuilder(string.Empty);
                    operations.Add(new PrioritySpecionForOperation(value[i].ToString(), index, ++index));
                    continue;
                }

                number.Append(value[i].ToString());
            }
            arguments.Add(number);
        }

        private void SetOrder()
        {
            int step = 0;
            foreach (PrioritySpecionForOperation rec in operations.Where(x => x.Operation == "/" ||
                                                                              x.Operation == "*"))
            {
                step = SetStep(rec, step);
            }
            foreach (PrioritySpecionForOperation rec in operations.Where(x => x.Operation == "+" ||
                                                                 (x.Operation == "-" && x.Step != -1)))
            {
                step = SetStep(rec, step);
            }
        }

        private int SetStep(PrioritySpecionForOperation rec, int step)
        {
            int index = operations.IndexOf(rec);
            step++;
            operations[index].Step = step;
            return step;
        }

        private string GetResult()
        {
            StringBuilder result = new StringBuilder(string.Empty);
            int countActions = operations.Max(x => x.Step);
            decimal resultOfOperation = 0;
            if (countActions > 1)
            {
                foreach (PrioritySpecionForOperation rec in operations.OrderBy(x => x.Step))
                {
                    if (rec.Step == -1) continue;
                    result.Append(GetNameOperation(rec) + Environment.NewLine);
                    result.Append(GetResult(rec, ref resultOfOperation) + Environment.NewLine);
                    DeleteAndUpdateIndexOfArguments(rec, resultOfOperation);
                }

                string line = "Ответ " + resultOfOperation.ToString() + Environment.NewLine + result.ToString();
                result = new StringBuilder(line);
            }

            else
            {
                int index = operations.Count == 1 ? 0 : 1;
                result.Append(GetResult(operations[index], ref resultOfOperation) + Environment.NewLine);
            }

            return result.ToString();
        }

        private string GetResult(PrioritySpecionForOperation value, ref decimal result)
        {
            if (value.IndexOne == 0)
            {
                PrioritySpecionForOperation checkSpecialSubtraction = operations.FirstOrDefault(x => x.Step == -1);
                if (checkSpecialSubtraction?.Operation == "-")
                {
                    return operation.Calc(value.OperationIndex, decimal.Parse(arguments[value.IndexOne].ToString()) * (-1),
                        decimal.Parse(arguments[value.IndexTwo].ToString()), ref result);
                }
            }
            return operation.Calc(value.OperationIndex, decimal.Parse(arguments[value.IndexOne].ToString()),
                decimal.Parse(arguments[value.IndexTwo].ToString()), ref result);
        }

        private void DeleteAndUpdateIndexOfArguments(PrioritySpecionForOperation value, decimal result)
        {
            arguments[value.IndexOne] = new StringBuilder(result.ToString());
            arguments.Remove(arguments[value.IndexTwo]);
            int index = 0;
            foreach (PrioritySpecionForOperation rec in operations.Where(x=>x.IndexOne >= value.IndexTwo ||
                                                                            x.IndexTwo >= value.IndexTwo))
            {
                index = operations.IndexOf(rec);
                operations[index].UpdateIndex(value.IndexTwo);
            }
        }

        private string GetNameOperation(PrioritySpecionForOperation value)
        {
            return "Действие " + value.Step.ToString() + " " + arguments[value.IndexOne].ToString() +
                   " " + value.Operation + " " + arguments[value.IndexTwo].ToString();
        }
    }
}
