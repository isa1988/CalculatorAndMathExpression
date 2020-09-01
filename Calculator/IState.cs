using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public interface IState
    {
        IState State { get; }

        bool IsStart { get; }
        void Digit(string key);
        void Equal();
        void Operation(string key);
        string Screen();

    }
}
