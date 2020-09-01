using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Calculator
{
    public class Calculator : IState
    {
        private bool isStart;
        public bool IsStart
        {
            get { return isStart; }
        }
        private IState state;
        public IState State
        {
            get { return state; }
        }

        protected string valueOne, valueTwo;
        protected string operation;
        public Calculator()
        {
            Clear();
        }

        protected Calculator(bool flag)
        {
            state = null;
            SetStart(flag);
        }

        public void Push(string key)
        {
            switch (key)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case ".":
                case ",": ((IState)this).Digit(key); break;
                case "c":
                case "C": Clear(); break;
                case "+":
                case "-":
                case "*":
                case "/": ((IState)this).Operation(key); break;
                case "=": ((IState)this).Equal(); break;
            }
        }

        protected void SetStart(bool value)
        {
            isStart = value;
        }
        void Clear()
        {
            state = new StateFirst();
            valueOne = string.Empty;
            valueTwo = string.Empty;
            operation = string.Empty;
        }

        protected void ChangeState(IState state)
        {
            this.state = state;
        }

        private void SetState(IState state)
        {
            if (state.State != null && state.State != state)
            {
                this.state = state.State;
                isStart = this.State.IsStart;
                SetState(this.state);
            }
        }

        void IState.Digit(string key)
        {
            state.Digit(key);
            SetState(state);
        }
        
        void IState.Equal()
        {
            state.Equal();
            SetState(state);
        }

        void IState.Operation(string key)
        {
            state.Operation(key);
            SetState(state);
        }

        string IState.Screen()
        {
            return state.Screen();
        }

        public override string ToString()
        {
            return ((IState)this).Screen();
        }
    }
}
