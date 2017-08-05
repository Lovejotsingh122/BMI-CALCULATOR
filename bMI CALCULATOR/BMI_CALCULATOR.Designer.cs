namespace bMI_CALCULATOR
{
    partial class BMI_CALCULATOR
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
            this.BMI = new System.Windows.Forms.Label();
            this.MYWEIGHT = new System.Windows.Forms.Label();
            this.MYHEIGHT = new System.Windows.Forms.Label();
            this.CALCULATE = new System.Windows.Forms.Button();
            this.RAD_METRIC = new System.Windows.Forms.RadioButton();
            this.RAD_IMPERIAL = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BMI
            // 
            this.BMI.AutoSize = true;
            this.BMI.Location = new System.Drawing.Point(24, 9);
            this.BMI.Name = "BMI";
            this.BMI.Size = new System.Drawing.Size(253, 31);
            this.BMI.TabIndex = 0;
            this.BMI.Text = "BMI CALCULATOR";
            this.BMI.Click += new System.EventHandler(this.label1_Click);
            // 
            // MYWEIGHT
            // 
            this.MYWEIGHT.AutoSize = true;
            this.MYWEIGHT.Location = new System.Drawing.Point(12, 208);
            this.MYWEIGHT.Name = "MYWEIGHT";
            this.MYWEIGHT.Size = new System.Drawing.Size(170, 31);
            this.MYWEIGHT.TabIndex = 2;
            this.MYWEIGHT.Text = "MY WEIGHT";
            // 
            // MYHEIGHT
            // 
            this.MYHEIGHT.AutoSize = true;
            this.MYHEIGHT.Location = new System.Drawing.Point(12, 141);
            this.MYHEIGHT.Name = "MYHEIGHT";
            this.MYHEIGHT.Size = new System.Drawing.Size(165, 31);
            this.MYHEIGHT.TabIndex = 3;
            this.MYHEIGHT.Text = "MY HEIGHT";
            // 
            // CALCULATE
            // 
            this.CALCULATE.Location = new System.Drawing.Point(65, 272);
            this.CALCULATE.Name = "CALCULATE";
            this.CALCULATE.Size = new System.Drawing.Size(184, 46);
            this.CALCULATE.TabIndex = 4;
            this.CALCULATE.Text = "CALCULATE";
            this.CALCULATE.UseVisualStyleBackColor = true;
            this.CALCULATE.Click += new System.EventHandler(this.button1_Click);
            // 
            // RAD_METRIC
            // 
            this.RAD_METRIC.AutoSize = true;
            this.RAD_METRIC.Location = new System.Drawing.Point(4, 66);
            this.RAD_METRIC.Name = "RAD_METRIC";
            this.RAD_METRIC.Size = new System.Drawing.Size(137, 35);
            this.RAD_METRIC.TabIndex = 5;
            this.RAD_METRIC.TabStop = true;
            this.RAD_METRIC.Text = "METRIC";
            this.RAD_METRIC.UseVisualStyleBackColor = true;
            this.RAD_METRIC.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RAD_IMPERIAL
            // 
            this.RAD_IMPERIAL.AutoSize = true;
            this.RAD_IMPERIAL.Location = new System.Drawing.Point(147, 66);
            this.RAD_IMPERIAL.Name = "RAD_IMPERIAL";
            this.RAD_IMPERIAL.Size = new System.Drawing.Size(159, 35);
            this.RAD_IMPERIAL.TabIndex = 6;
            this.RAD_IMPERIAL.TabStop = true;
            this.RAD_IMPERIAL.Text = "IMPERIAL";
            this.RAD_IMPERIAL.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 38);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(183, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 38);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(18, 324);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(274, 38);
            this.textBox3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(304, 381);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RAD_IMPERIAL);
            this.Controls.Add(this.RAD_METRIC);
            this.Controls.Add(this.CALCULATE);
            this.Controls.Add(this.MYHEIGHT);
            this.Controls.Add(this.MYWEIGHT);
            this.Controls.Add(this.BMI);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "bmi calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BMI;
        private System.Windows.Forms.Label MYWEIGHT;
        private System.Windows.Forms.Label MYHEIGHT;
        private System.Windows.Forms.Button CALCULATE;
        private System.Windows.Forms.RadioButton RAD_METRIC;
        private System.Windows.Forms.RadioButton RAD_IMPERIAL;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

