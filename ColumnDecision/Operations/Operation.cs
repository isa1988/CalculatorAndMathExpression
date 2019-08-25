using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumnDecision.Operations
{
    class Operation
    {
        private ICalc[] calcs;
        Stack<ICalc> calcsHistory;

        public Operation()
        {
            calcs = new ICalc[4];
            for (int i = 0; i < calcs.Length; i++)
            {
                calcs[i] = new NoCommand();
            }
            calcsHistory = new Stack<ICalc>();
        }

        public void SetCommand(int number, ICalc calc)
        {
            calcs[number] = calc;
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
