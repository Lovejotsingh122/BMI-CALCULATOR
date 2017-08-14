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
            this.CalculateBMI = new System.Windows.Forms.Button();
            this._METRIC = new System.Windows.Forms.RadioButton();
            this._IMPERIAL = new System.Windows.Forms.RadioButton();
            this.Height = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.TextBox();
            this.BMI_Value = new System.Windows.Forms.TextBox();
            this.cm = new System.Windows.Forms.Label();
            this.kg = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
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
            this.MYWEIGHT.Location = new System.Drawing.Point(-2, 158);
            this.MYWEIGHT.Name = "MYWEIGHT";
            this.MYWEIGHT.Size = new System.Drawing.Size(170, 31);
            this.MYWEIGHT.TabIndex = 2;
            this.MYWEIGHT.Text = "MY WEIGHT";
            // 
            // MYHEIGHT
            // 
            this.MYHEIGHT.AutoSize = true;
            this.MYHEIGHT.Location = new System.Drawing.Point(-2, 114);
            this.MYHEIGHT.Name = "MYHEIGHT";
            this.MYHEIGHT.Size = new System.Drawing.Size(165, 31);
            this.MYHEIGHT.TabIndex = 3;
            this.MYHEIGHT.Text = "MY HEIGHT";
            // 
            // CalculateBMI
            // 
            this.CalculateBMI.Location = new System.Drawing.Point(62, 202);
            this.CalculateBMI.Name = "CalculateBMI";
            this.CalculateBMI.Size = new System.Drawing.Size(184, 46);
            this.CalculateBMI.TabIndex = 4;
            this.CalculateBMI.Text = "CALCULATE";
            this.CalculateBMI.UseVisualStyleBackColor = true;
            this.CalculateBMI.Click += new System.EventHandler(this.button1_Click);
            // 
            // _METRIC
            // 
            this._METRIC.AutoSize = true;
            this._METRIC.Location = new System.Drawing.Point(4, 66);
            this._METRIC.Name = "_METRIC";
            this._METRIC.Size = new System.Drawing.Size(137, 35);
            this._METRIC.TabIndex = 5;
            this._METRIC.TabStop = true;
            this._METRIC.Text = "METRIC";
            this._METRIC.UseVisualStyleBackColor = true;
            this._METRIC.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // _IMPERIAL
            // 
            this._IMPERIAL.AutoSize = true;
            this._IMPERIAL.Location = new System.Drawing.Point(147, 66);
            this._IMPERIAL.Name = "_IMPERIAL";
            this._IMPERIAL.Size = new System.Drawing.Size(159, 35);
            this._IMPERIAL.TabIndex = 6;
            this._IMPERIAL.TabStop = true;
            this._IMPERIAL.Text = "IMPERIAL";
            this._IMPERIAL.UseVisualStyleBackColor = true;
            this._IMPERIAL.CheckedChanged += new System.EventHandler(this._IMPERIAL_CheckedChanged);
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(169, 117);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(64, 38);
            this.Height.TabIndex = 7;
            this.Height.TextChanged += new System.EventHandler(this.Height_TextChanged);
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(169, 158);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(64, 38);
            this.Weight.TabIndex = 8;
            this.Weight.TextChanged += new System.EventHandler(this.Weight_TextChanged);
            // 
            // BMI_Value
            // 
            this.BMI_Value.Location = new System.Drawing.Point(18, 254);
            this.BMI_Value.Name = "BMI_Value";
            this.BMI_Value.Size = new System.Drawing.Size(274, 38);
            this.BMI_Value.TabIndex = 9;
            this.BMI_Value.TextChanged += new System.EventHandler(this.BMI_Value_TextChanged);
            // 
            // cm
            // 
            this.cm.AutoSize = true;
            this.cm.Location = new System.Drawing.Point(239, 124);
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(66, 31);
            this.cm.TabIndex = 10;
            this.cm.Text = "Inch";
            this.cm.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // kg
            // 
            this.kg.AutoSize = true;
            this.kg.Location = new System.Drawing.Point(239, 158);
            this.kg.Name = "kg";
            this.kg.Size = new System.Drawing.Size(49, 31);
            this.kg.TabIndex = 11;
            this.kg.Text = "lbs";
            this.kg.Click += new System.EventHandler(this.kg_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(65, 299);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(184, 46);
            this.Reset.TabIndex = 12;
            this.Reset.Text = "Clear";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // BMI_CALCULATOR
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.kg);
            this.Controls.Add(this.cm);
            this.Controls.Add(this.BMI_Value);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.Height);
            this.Controls.Add(this._IMPERIAL);
            this.Controls.Add(this._METRIC);
            this.Controls.Add(this.CalculateBMI);
            this.Controls.Add(this.MYHEIGHT);
            this.Controls.Add(this.MYWEIGHT);
            this.Controls.Add(this.BMI);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BMI_CALCULATOR";
            this.Text = "bmi calculator";
            this.Load += new System.EventHandler(this.BMI_CALCULATOR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BMI;
        private System.Windows.Forms.Label MYWEIGHT;
        private System.Windows.Forms.Label MYHEIGHT;
        private System.Windows.Forms.Button CalculateBMI;
        private System.Windows.Forms.RadioButton _METRIC;
        private System.Windows.Forms.RadioButton _IMPERIAL;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.TextBox BMI_Value;
        private System.Windows.Forms.Label cm;
        private System.Windows.Forms.Label kg;
        private System.Windows.Forms.Button Reset;
    }
}

