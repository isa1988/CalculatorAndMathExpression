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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            ShowForn(new frm_Calculate());
        }

        private void btn_MathExpression_Click(object sender, EventArgs e)
        {
            ShowForn(new frm_MathExpression());
        }

        private void ShowForn(Form form)
        {
            form.ShowDialog();
        }
    }
}
