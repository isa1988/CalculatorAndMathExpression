using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathExpression;

namespace WFAApp
{
    public partial class frmCalc : Form
    {
        public frmCalc()
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
            TaskOne taskOne = new TaskOne();
            txtImport.Text = txtExport.Text + Environment.NewLine;
            txtImport.Text += taskOne.GetResult(txtExport.Text);
            txtExport.Text = string.Empty;
        }
    }
}
