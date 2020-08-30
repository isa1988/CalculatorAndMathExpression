using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpression.Operations.Division
{
    class DivisionHelper
    {
        /// <summary>
        /// Вспомогательный класс для значений делений
        /// </summary>
        /// <param name="receivedValue">Полученное</param>
        /// <param name="transformedValue">Преобразованное значение</param>
        public DivisionHelper(int receivedValue, int transformedValue)
        {
            ReceivedValue = receivedValue;
            TransformedValue = transformedValue;
        }
        
        /// <summary>
        /// Полученное значение
        /// </summary>
        public int ReceivedValue { get; private set; }

        /// <summary>
        /// Преобразованное значение
        /// </summary>
        public int TransformedValue { get; private set; }
    }
}
