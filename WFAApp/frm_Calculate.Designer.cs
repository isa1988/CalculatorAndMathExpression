namespace WFAApp
{
    partial class frm_Calculate
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
            this.lst_Result = new System.Windows.Forms.ListBox();
            this.btn_Four = new System.Windows.Forms.Button();
            this.btn_Five = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Addition = new System.Windows.Forms.Button();
            this.btn_Subtraction = new System.Windows.Forms.Button();
            this.btn_Nine = new System.Windows.Forms.Button();
            this.btn_Eight = new System.Windows.Forms.Button();
            this.btn_Seven = new System.Windows.Forms.Button();
            this.btn_Multiplication = new System.Windows.Forms.Button();
            this.btn_Division = new System.Windows.Forms.Button();
            this.btn_Clean = new System.Windows.Forms.Button();
            this.btn_Three = new System.Windows.Forms.Button();
            this.btn_Two = new System.Windows.Forms.Button();
            this.btn_One = new System.Windows.Forms.Button();
            this.btn_Result = new System.Windows.Forms.Button();
            this.btn_Point = new System.Windows.Forms.Button();
            this.btn_Zero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_Result
            // 
            this.lst_Result.FormattingEnabled = true;
            this.lst_Result.Location = new System.Drawing.Point(1, -2);
            this.lst_Result.Name = "lst_Result";
            this.lst_Result.Size = new System.Drawing.Size(318, 69);
            this.lst_Result.TabIndex = 0;
            // 
            // btn_Four
            // 
            this.btn_Four.Location = new System.Drawing.Point(1, 235);
            this.btn_Four.Name = "btn_Four";
            this.btn_Four.Size = new System.Drawing.Size(75, 75);
            this.btn_Four.TabIndex = 1;
            this.btn_Four.Tag = "4";
            this.btn_Four.Text = "4";
            this.btn_Four.UseVisualStyleBackColor = true;
            this.btn_Four.Click += new System.EventHandler(this.btn_General_Click);
            // 
            // btn_Five
            // 
            this.btn_Five.Location = new System.Drawing.Point(82, 235);
            this.btn_Five.Name = "btn_Five";
            this.btn_Five.Size = new System.Drawing.Size(75, 75);
            this.btn_Five.TabIndex = 2;
            this.btn_Five.Tag = "5";
            this.btn_Five.Text = "5";
            this.btn_Five.UseVisualStyleBackColor = true;
            this.btn_Five.Click += new System.EventHandler(this.btn_General_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(163, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 75);
            this.button3.TabIndex = 3;
            this.button3.Tag = "6";
            this.button3.Text = "6";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_General_Click);
            // 
            // btn_Addition
            // 
            this.btn_Addition.Location = new System.Drawing.Point(244, 235);
            this.btn_Addition.Name = "btn_Addition";
            this.btn_Addition.Size = new System.Drawing.Size(75, 75);
            this.btn_Addition.TabIndex = 4;
            this.btn_Addition.Tag = "+";
            this.btn_Addition.Text = "+";
            this.btn_Addition.UseVisualStyleBackColor = true;
            this.btn_Addition.Click += new System.EventHandler(this.btn_Operation_Click);
            // 
            // btn_Subtraction
            // 
            this.btn_Subtraction.Location = new System.Drawing.Point(244, 154);
            this.btn_Subtraction.Name = "btn_Subtraction";
            this.btn_Subtraction.Size = new System.Drawing.Size(75, 75);
            this.btn_Subtraction.TabIndex = 8;
            this.btn_Subtraction.Tag = "-";
            this.btn_Subtraction.Text = "-";
            this.btn_Subtraction.UseVisualStyleBackColor = true;
            this.btn_Subtraction.Click += new System.EventHandler(this.btn_Operation_Click);
            // 
            // btn_Nine
            // 
            this.btn_Nine.Location = new System.Drawing.Point(163, 154);
            this.btn_Nine.Name = "btn_Nine";
            this.btn_Nine.Size = new System.Drawing.Size(75, 75);
            this.btn_Nine.TabIndex = 7;
            this.btn_Nine.Tag = "9";
            this.btn_Nine.Text = "9";
            this.btn_Nine.UseVisualStyleBackColor = true;
            this.btn_Nine.Click += new System.EventHandler(this.btn_General_Click);
            // 
            // btn_Eight
            // 
            this.btn_Eight.Location = new System.Drawing.Point(82, 154);
            this.btn_Eight.Name = "btn_Eight";
            this.btn_Eight.Size = new System.Drawing.Size(75, 75);
            this.btn_Eight.TabIndex = 6;
            this.btn_Eight.Tag = "8";
            this.btn_Eight.Text = "8";
            this.btn_Eight.UseVisualStyleBackColor = true;
            this.btn_Eight.Click += new System.EventHandler(this.btn_General_Click);
            // 
            // btn_Seven
            // 
            this.btn_Seven.Location = new System.Drawing.Point(1, 154);
            this.btn_Seven.Name = "btn_Seven";
            this.btn_Seven.Size = new System.Drawing.Size(75, 75);
            this.btn_Seven.TabIndex = 5;
            this.btn_Seven.Tag = "7";
            this.btn_Seven.Text = "7";
            this.btn_Seven.UseVisualStyleBackColor = true;
            this.btn_Seven.Click += new System.EventHandler(this.btn_General_Click);
            // 
            // btn_Multiplication
            // 
            this.btn_Multiplication.Location = new System.Drawing.Point(244, 73);
            this.btn_Multiplication.Name = "btn_Multiplication";
            this.btn_Multiplication.Size = new System.Drawing.Size(75, 75);
            this.btn_Multiplication.TabIndex = 12;
            this.btn_Multiplication.Tag = "*";
            this.btn_Multiplication.Text = "*";
            this.btn_Multiplication.UseVisualStyleBackColor = true;
            this.btn_Multiplication.Click += new System.EventHandler(this.btn_Operation_Click);
            // 
            // btn_Division
            // 
            this.btn_Division.Location = new System.Drawing.Point(163, 73);
            this.btn_Division.Name = "btn_Division";
            this.btn_Division.Size = new System.Drawing.Size(75, 75);
            this.btn_Division.TabIndex = 11;
            this.btn_Division.Tag = "/";
            this.btn_Division.Text = "/";
            this.btn_Division.UseVisualStyleBackColor = true;
            this.btn_Division.Click += new System.EventHandler(this.btn_Operation_Click);
            // 
            // btn_Clean
            // 
            this.btn_Clean.Location = new System.Drawing.Point(1, 73);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(156, 75);
            this.btn_Clean.TabIndex = 9;
            this.btn_Clean.Tag = "C";
            this.btn_Clean.Text = "C";
            this.btn_Clean.UseVisualStyleBackColor = true;
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click);
            // 
            // btn_Three
            // 
            this.btn_Three.Location = new System.Drawing.Point(163, 316);
            this.btn_Three.Name = "btn_Three";
            this.btn_Three.Size = new System.Drawing.Size(75, 75);
            this.btn_Three.TabIndex = 22;
            this.btn_Three.Tag = "3";
            this.btn_Three.Text = "3";
            this.btn_Three.UseVisualStyleBackColor = true;
            this.btn_Three.Click += new System.EventHandler(this.btn_General_Click);
            // 
            // btn_Two
            // 
            this.btn_Two.Location = new System.Drawing.Point(82, 316);
            this.btn_Two.Name = "btn_Two";
            this.btn_Two.Size = new System.Drawing.Size(75, 75);
            this.btn_Two.TabIndex = 21;
            this.btn_Two.Tag = "2";
            this.btn_Two.Text = "2";
            this.btn_Two.UseVisualStyleBackColor = true;
            this.btn_Two.Click += new System.EventHandler(this.btn_General_Click);
            // 
            // btn_One
            // 
            this.btn_One.Location = new System.Drawing.Point(1, 316);
            this.btn_One.Name = "btn_One";
            this.btn_One.Size = new System.Drawing.Size(75, 75);
            this.btn_One.TabIndex = 20;
            this.btn_One.Tag = "1";
            this.btn_One.Text = "1";
            this.btn_One.UseVisualStyleBackColor = true;
            this.btn_One.Click += new System.EventHandler(this.btn_General_Click);
            // 
            // btn_Result
            // 
            this.btn_Result.Location = new System.Drawing.Point(244, 316);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(75, 156);
            this.btn_Result.TabIndex = 19;
            this.btn_Result.Tag = "=";
            this.btn_Result.Text = "=";
            this.btn_Result.UseVisualStyleBackColor = true;
            this.btn_Result.Click += new System.EventHandler(this.btn_Operation_Click);
            // 
            // btn_Point
            // 
            this.btn_Point.Location = new System.Drawing.Point(163, 397);
            this.btn_Point.Name = "btn_Point";
            this.btn_Point.Size = new System.Drawing.Size(75, 75);
            this.btn_Point.TabIndex = 18;
            this.btn_Point.Tag = ".";
            this.btn_Point.Text = ".";
            this.btn_Point.UseVisualStyleBackColor = true;
            this.btn_Point.Click += new System.EventHandler(this.btn_General_Click);
            // 
            // btn_Zero
            // 
            this.btn_Zero.Location = new System.Drawing.Point(1, 397);
            this.btn_Zero.Name = "btn_Zero";
            this.btn_Zero.Size = new System.Drawing.Size(156, 75);
            this.btn_Zero.TabIndex = 16;
            this.btn_Zero.Tag = "0";
            this.btn_Zero.Text = "0";
            this.btn_Zero.UseVisualStyleBackColor = true;
            this.btn_Zero.Click += new System.EventHandler(this.btn_General_Click);
            // 
            // frm_Calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 474);
            this.Controls.Add(this.btn_Three);
            this.Controls.Add(this.btn_Two);
            this.Controls.Add(this.btn_One);
            this.Controls.Add(this.btn_Result);
            this.Controls.Add(this.btn_Point);
            this.Controls.Add(this.btn_Zero);
            this.Controls.Add(this.btn_Multiplication);
            this.Controls.Add(this.btn_Division);
            this.Controls.Add(this.btn_Clean);
            this.Controls.Add(this.btn_Subtraction);
            this.Controls.Add(this.btn_Nine);
            this.Controls.Add(this.btn_Eight);
            this.Controls.Add(this.btn_Seven);
            this.Controls.Add(this.btn_Addition);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Five);
            this.Controls.Add(this.btn_Four);
            this.Controls.Add(this.lst_Result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Calculate";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.frm_Calculate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Result;
        private System.Windows.Forms.Button btn_Four;
        private System.Windows.Forms.Button btn_Five;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Addition;
        private System.Windows.Forms.Button btn_Subtraction;
        private System.Windows.Forms.Button btn_Nine;
        private System.Windows.Forms.Button btn_Eight;
        private System.Windows.Forms.Button btn_Seven;
        private System.Windows.Forms.Button btn_Multiplication;
        private System.Windows.Forms.Button btn_Division;
        private System.Windows.Forms.Button btn_Clean;
        private System.Windows.Forms.Button btn_Three;
        private System.Windows.Forms.Button btn_Two;
        private System.Windows.Forms.Button btn_One;
        private System.Windows.Forms.Button btn_Result;
        private System.Windows.Forms.Button btn_Point;
        private System.Windows.Forms.Button btn_Zero;
    }
}