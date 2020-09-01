using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAApp
{
    public partial class frm_Calculate : Form
    {
        private Calculator.Calculator calculator;
        private bool isOperation;
        private bool isFirst;
        public frm_Calculate()
        {
            calculator = new Calculator.Calculator();
            InitializeComponent();
        }

        private void btn_General_Click(object sender, EventArgs e)
        {
            string line = ((Button) sender).Tag.ToString();
            calculator.Push(line);
            if (calculator.IsStart)
            {
                CleanList(calculator.ToString());
                isFirst = true;
            }
            else
            {
                lst_Result.Items[lst_Result.Items.Count - 1] = calculator.ToString();
            }

            if (isOperation)
            {
                isFirst = false;
            }
            isOperation = false;
        }

        private void btn_Operation_Click(object sender, EventArgs e)
        {
            string line = ((Button)sender).Tag.ToString();
            calculator.Push(line);

            if (isFirst)
            {
                AddLineInList(line);
            }
            else
            {
                string key = calculator.ToString().Substring(0, calculator.ToString().Length - 2);

                if (key.Contains("="))
                {
                    AddLineInList(calculator.ToString());
                }
                else
                {
                    AddLineInList("= " + key + Environment.NewLine + " " + line);
                }
            }

            if (line != "=")
            {
                isOperation = true;
            }
        }

        private void AddLineInList(string value)
        {
            if (isOperation)
            {
                lst_Result.Items[lst_Result.Items.Count - 2] = value;
            }
            else
            {
                lst_Result.Items.Add(value);
                lst_Result.Items.Add(string.Empty);
                
            }
        }

        private void frm_Calculate_Load(object sender, EventArgs e)
        {
            lst_Result.Items.Add(string.Empty);
            isOperation = false;
            isFirst = true;
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            string line = ((Button)sender).Tag.ToString();
            calculator.Push(line);
            CleanList();
            isOperation = false;
            isFirst = true;
        }

        private void CleanList(string value = "")
        {
            lst_Result.Items.Clear();
            lst_Result.Items.Add(value);
        }
    }
}
