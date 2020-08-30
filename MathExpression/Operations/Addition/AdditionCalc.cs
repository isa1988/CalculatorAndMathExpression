using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpression.Operations.Addition
{
    class AdditionCalc : ICalc
    {
        private Addition addition;

        public AdditionCalc(Addition addition)
        {
            this.addition = addition;
        }

        public AdditionCalc()
        {
            this.addition = new Addition();
        }

        public string Calc(decimal argumetOne, decimal argumetTwo, ref decimal result)
        {
            return addition.Sum(argumetOne, argumetTwo, ref result);
        }

        public decimal Calc(decimal argumetOne, decimal argumetTwo)
        {
            return addition.Sum(argumetOne, argumetTwo);
        }
    }
}
