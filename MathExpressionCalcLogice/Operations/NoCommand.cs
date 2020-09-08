using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressionCalcLogice.Operations
{
    public class NoCommand : ICalc
    {
        public string Calc(decimal argumetOne, decimal argumetTwo, ref decimal result)
        {
            return string.Empty;
        }

        public decimal Calc(decimal argumetOne, decimal argumetTwo)
        {
            return 0;
        }
    }
}
