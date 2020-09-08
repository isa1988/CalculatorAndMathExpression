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
    public partial class frm_MathExpression : Form
    {
        public frm_MathExpression()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (txtExport.Text.Trim().Length == 0)
            {
                MessageBox.Show("Вы не заполнили выражение");
                return;
            }
            MathExpressionWithBrackets.MathExpressionWithBracketsCalc mathExpression = new MathExpressionWithBrackets.MathExpressionWithBracketsCalc();
            txtImport.Text = txtExport.Text + Environment.NewLine;
            txtImport.Text += mathExpression.GetResult(txtExport.Text);
            txtExport.Text = string.Empty;
        }
    }
}
