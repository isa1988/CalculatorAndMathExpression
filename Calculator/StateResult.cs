using System;

namespace Calculator
{
    class StateResult : Calculator, IState
    {

        public StateResult(string valueOne, string operation, string valueTwo) : base(false)
        {
            base.valueOne = valueOne;
            base.operation = operation;
            base.valueTwo = valueTwo;
        }

        private void Calculate()
        {
            double x = GetNuber(base.valueOne);
            double y = GetNuber(base.valueTwo);
            double result = x;
            switch (base.operation)
            {
                case "+": result = x + y; break;
                case "-": result = x - y; break;
                case "*": result = x * y; break;
                case "/": result = (y != 0) ? x / y : 0; break;
            }

            base.valueOne = result.ToString().Replace(",", ".");
        }

        private double GetNuber(string vaule)
        {
            if (string.IsNullOrWhiteSpace(vaule)) return 0;
            vaule = vaule.Replace(".", ",");
            double retVal = double.Parse(vaule);
            return retVal;
        }

        public void Digit(string key)
        {
            base.ChangeState(new StateFirst());
            base.State.Digit(key);
        }

        public void Equal()
        {
            Calculate();
        }

        public void Operation(string key)
        {
            Calculate();
            base.ChangeState(new StateOperation(base.valueOne));
            base.State.Operation(key);
        }

        public string Screen()
        {
            return "= " + base.valueOne;
        }
    }
}