﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressionCalcLogice.Operations
{
    /// <summary>
    /// Математическая операция
    /// </summary>
    public enum OperationType : int
    {
        /// <summary>
        /// Умножение
        /// </summary>
        Multiplication = 0,

        /// <summary>
        /// Деление
        /// </summary>
        Division = 1,

        /// <summary>
        /// Сложение
        /// </summary>
        Addition = 2,

        /// <summary>
        /// Вычетание
        /// </summary>
        Subtraction = 3
    }
}
