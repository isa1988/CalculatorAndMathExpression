
namespace Calculator
{
    class StateFirst : Calculator, IState
    {
        private bool isPoing;

        public StateFirst() : base(true)
        {
            base.valueOne = string.Empty;
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

            if (base.valueOne.Length > 0)
            {
                base.SetStart(false);
            }

            base.valueOne += key; 
        }

        public void Equal()
        {
            base.ChangeState(new StateResult(base.valueOne, string.Empty, string.Empty));
            State.Equal();
        }
        
        public void Operation(string key)
        {
            base.ChangeState(new StateOperation(base.valueOne));
            State.Operation(key);
        }

        public string Screen()
        {
            return base.valueOne; 
        }
    }
}