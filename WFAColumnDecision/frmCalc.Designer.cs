namespace WFAColumnDecision
{
    partial class frmCalc
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtExport = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtImport = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCalc);
            this.panel1.Controls.Add(this.txtExport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 33);
            this.panel1.TabIndex = 0;
            // 
            // txtExport
            // 
            this.txtExport.Location = new System.Drawing.Point(12, 10);
            this.txtExport.Name = "txtExport";
            this.txtExport.Size = new System.Drawing.Size(695, 20);
            this.txtExport.TabIndex = 0;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(713, 7);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Рассчитать";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtImport
            // 
            this.txtImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtImport.Location = new System.Drawing.Point(0, 33);
            this.txtImport.Multiline = true;
            this.txtImport.Name = "txtImport";
            this.txtImport.ReadOnly = true;
            this.txtImport.Size = new System.Drawing.Size(800, 528);
            this.txtImport.TabIndex = 1;
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.txtImport);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "frmCalc";
            this.Text = "Задание 1 решить выражение";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtExport;
        private System.Windows.Forms.TextBox txtImport;
    }
}

