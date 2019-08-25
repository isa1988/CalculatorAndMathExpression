using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumnDecision
{
    /// <summary>
    /// Вспомогательный приоритет действий
    /// </summary>
    class PrioritySpecionForOperation
    {
        /// <summary>
        /// Вспомогательный приоритет действий
        /// </summary>
        /// <param name="operation">Операция</param>
        /// <param name="indexOne">Индекс на первое значение</param>
        /// <param name="indexTwo">Индекс на второе значение</param>
        /// <param name="step">Приоритет</param>
        public PrioritySpecionForOperation(string operation, int indexOne, int indexTwo, int step)
        {
            Operation = operation;
            IndexOne = indexOne;
            IndexTwo = indexTwo;
            Step = step;
        }

        /// <summary>
        /// Вспомогательный приоритет действий
        /// </summary>
        /// <param name="operation">Операция</param>
        /// <param name="indexOne">Индекс на первое значение</param>
        /// <param name="indexTwo">Индекс на второе значение</param>
        public PrioritySpecionForOperation(string operation, int indexOne, int indexTwo)
        {
            Operation = operation;
            IndexOne = indexOne;
            IndexTwo = indexTwo;
        }

        /// <summary>
        /// Операция
        /// </summary>
        public string Operation { get; private set; }

        /// <summary>
        /// Индекс на первое значение
        /// </summary>
        public int IndexOne { get; set; }

        /// <summary>
        /// Индекс на второе значение
        /// </summary>
        public int IndexTwo { get; set; }

        /// <summary>
        /// Приоритет
        /// </summary>
        public int Step { get; set; }
    }
}
