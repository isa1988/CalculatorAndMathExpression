namespace WFAApp
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_MathExpression = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(38, 54);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(135, 55);
            this.btn_Calculate.TabIndex = 0;
            this.btn_Calculate.Text = "Калькулятор";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_MathExpression
            // 
            this.btn_MathExpression.Location = new System.Drawing.Point(38, 134);
            this.btn_MathExpression.Name = "btn_MathExpression";
            this.btn_MathExpression.Size = new System.Drawing.Size(135, 55);
            this.btn_MathExpression.TabIndex = 1;
            this.btn_MathExpression.Text = "Математическое выражение";
            this.btn_MathExpression.UseVisualStyleBackColor = true;
            this.btn_MathExpression.Click += new System.EventHandler(this.btn_MathExpression_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_MathExpression);
            this.Controls.Add(this.btn_Calculate);
            this.Name = "frm_Main";
            this.Text = "Главная";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_MathExpression;
    }
}