using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpression.Operations.Division
{
    /// <summary>
    /// Операймя деления
    /// </summary>
    class DivisionCalc : ICalc
    {
        private Division division;

        public DivisionCalc(Division division)
        {
            this.division = division;
        }

        public DivisionCalc()
        {
            this.division = new Division();
        }
        /// <summary>
        /// Деление в столбик
        /// </summary>
        /// <param name="argumetOne">Делимое</param>
        /// <param name="argumetTwo">Делитель</param>
        /// <param name="result">Частное</param>
        /// <returns></returns>
        public string Calc(decimal argumetOne, decimal argumetTwo, ref decimal result)
        {
            return division.Quotient(argumetOne, argumetTwo, ref result);
        }

        /// <summary>
        /// Деление
        /// </summary>
        /// <param name="argumetOne">Делимое</param>
        /// <param name="argumetTwo">Делитель</param>
        /// <returns></returns>
        public decimal Calc(decimal argumetOne, decimal argumetTwo)
        {
            return division.Quotient(argumetOne, argumetTwo);
        }
    }
}
