﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressionCalcLogice.Operations.Subtraction
{
    public class SubtractionCalc : ICalc
    {
        private Subtraction subtraction;
        
        public SubtractionCalc()
        {
            this.subtraction = new Subtraction();
        }

        public string Calc(decimal argumetOne, decimal argumetTwo, ref decimal result)
        {
            return subtraction.Difference(argumetOne, argumetTwo, ref result);
        }

        public decimal Calc(decimal argumetOne, decimal argumetTwo)
        {
            return subtraction.Difference(argumetOne, argumetTwo);
        }
    }
}
