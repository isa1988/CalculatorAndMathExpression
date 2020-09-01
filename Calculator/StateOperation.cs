namespace Calculator
{
    class StateOperation : Calculator, IState
    {
        public StateOperation(string valueOne) : base(true)
        {
            base.operation = string.Empty;
            base.valueOne = valueOne;
        }

        public void Digit(string key)
        {
            base.ChangeState(new StateSecond(base.valueOne, base.operation));
            State.Digit(key);
        }

        public void Equal()
        {
            base.ChangeState(new StateResult(base.valueOne, base.operation, base.valueOne));
            State.Equal();
        }

        public void Operation(string key)
        {
            base.operation = key;
        }

        public string Screen()
        {
            return base.valueOne + " " + base.operation;
        }
    }
}