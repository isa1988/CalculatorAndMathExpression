using MathExpressionCalcLogice.Operations.Addition;
using MathExpressionCalcLogice.Operations.Division;
using MathExpressionCalcLogice.Operations.Multiplication;
using MathExpressionCalcLogice.Operations.Subtraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressionCalcLogice.Operations
{
    public class Operation
    {
        private ICalc[] calcs;
        private string[] operationsName;
        Stack<ICalc> calcsHistory;

        public Operation()
        {
            calcs = new ICalc[4];

            SetCommand((int)OperationType.Multiplication, new MultiplicationCalc());
            SetCommand((int)OperationType.Division, new DivisionCalc());
            SetCommand((int)OperationType.Addition, new AdditionCalc());
            SetCommand((int)OperationType.Subtraction, new SubtractionCalc());

            operationsName = new string[4] {"*", "/", "+", "-"};

            calcsHistory = new Stack<ICalc>();
        }

        public void SetCommand(int number, ICalc calc)
        {
            calcs[number] = calc;
        }
        public string Calc(string nameOperation, decimal argumetOne, decimal argumetTwo, ref decimal result)
        {
            // добавляем выполненную команду в историю команд
            int index = Array.IndexOf(operationsName, nameOperation);
            calcsHistory.Push(calcs[index]);
            return calcs[index].Calc(argumetOne, argumetTwo, ref result);
        }

        public string Calc(int number, decimal argumetOne, decimal argumetTwo, ref decimal result)
        {
            // добавляем выполненную команду в историю команд
            calcsHistory.Push(calcs[number]);
            return calcs[number].Calc(argumetOne, argumetTwo, ref result);
        }
        
        /*public void PressUndoButton()
        {
            if (calcsHistory.Count > 0)
            {
                ICalc undoCalc = calcsHistory.Pop();
                undoCalc.Undo();
            }
        }*/
    }
}
