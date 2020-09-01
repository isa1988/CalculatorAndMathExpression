namespace Calculator
{
    class StateSecond : Calculator, IState
    {
        private bool isPoing;
        public StateSecond(string valueOne, string operation) : base(true)
        {
            base.valueOne = valueOne;
            base.operation = operation;
            base.valueTwo = string.Empty;
            isPoing = false;
        }

        public void Digit(string key)
        {
            if (key == "." || key == ",")
            {
                if (isPoing)
                {
                    return;
                }

                key = ".";
                isPoing = true;
            }
            base.valueTwo += key;
        }

        public void Equal()
        {
            base.ChangeState(new StateResult(base.valueOne, base.operation, base.valueTwo));
            State.Equal();
        }

        public void Operation(string key)
        {
            base.ChangeState(new StateResult(base.valueOne, base.operation, base.valueTwo));
            State.Operation(key);
        }

        public string Screen()
        {
            return base.operation + " " + base.valueTwo;
        }
    }
}