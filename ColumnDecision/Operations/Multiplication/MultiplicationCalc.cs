using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumnDecision.Operations.Multiplication
{
    class MultiplicationCalc : ICalc
    {
        private Multiplication multiplication;

        public MultiplicationCalc(Multiplication multiplication)
        {
            this.multiplication = multiplication;
        }

        public MultiplicationCalc()
        {
            this.multiplication = new Multiplication();
        }

        public string Calc(decimal argumetOne, decimal argumetTwo, ref decimal result)
        {
            return multiplication.Composition(argumetOne, argumetTwo, ref result);
        }

        public decimal Calc(decimal argumetOne, decimal argumetTwo)
        {
            return multiplication.Composition(argumetOne, argumetTwo);
        }
    }
}
