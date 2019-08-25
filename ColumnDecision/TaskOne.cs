using ColumnDecision.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColumnDecision.Operations.Addition;
using ColumnDecision.Operations.Multiplication;
using ColumnDecision.Operations.Subtraction;

namespace ColumnDecision
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

        /// <summary>
        /// Вычисление
        /// </summary>
        /// <param name="value">Математическое выражение</param>
        public string GetResult(string value)
        {
            arguments = new List<StringBuilder>();
            operations = new List<PrioritySpecionForOperation>();
            StringBuilder number = new StringBuilder(string.Empty);
            int index = 0;
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i].ToString() == " ") continue;
                if (i == 0 && value[i].ToString() == "-")
                {
                    operations.Add(new PrioritySpecionForOperation("-", 0, 0));
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
            Operation operation = new Operation();
            operation.SetCommand(0, new MultiplicationCalc());
            operation.SetCommand(1, new AdditionCalc());
            operation.SetCommand(2, new SubtractionCalc());
            decimal result = 0;
            return operation.Calc(2, decimal.Parse(arguments[0].ToString()), 
                                     decimal.Parse(arguments[1].ToString()), ref result);
        }
    }
}
