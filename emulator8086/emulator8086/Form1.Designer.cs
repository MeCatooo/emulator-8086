
namespace emulator8086
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AX = new System.Windows.Forms.Label();
            this.BX = new System.Windows.Forms.Label();
            this.CX = new System.Windows.Forms.Label();
            this.DX = new System.Windows.Forms.Label();
            this.AL = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BL = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DL = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBoxOD = new System.Windows.Forms.ComboBox();
            this.comboBoxDO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.TempTExt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 770);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DX";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AX);
            this.panel1.Controls.Add(this.BX);
            this.panel1.Controls.Add(this.CX);
            this.panel1.Controls.Add(this.DX);
            this.panel1.Controls.Add(this.AL);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.BL);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.CL);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.DL);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1109, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 826);
            this.panel1.TabIndex = 1;
            // 
            // AX
            // 
            this.AX.AutoSize = true;
            this.AX.Location = new System.Drawing.Point(121, 94);
            this.AX.Name = "AX";
            this.AX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AX.Size = new System.Drawing.Size(13, 13);
            this.AX.TabIndex = 15;
            this.AX.Text = "0";
            // 
            // BX
            // 
            this.BX.AutoSize = true;
            this.BX.Location = new System.Drawing.Point(121, 288);
            this.BX.Name = "BX";
            this.BX.Size = new System.Drawing.Size(13, 13);
            this.BX.TabIndex = 14;
            this.BX.Text = "0";
            // 
            // CX
            // 
            this.CX.AutoSize = true;
            this.CX.Location = new System.Drawing.Point(121, 515);
            this.CX.Name = "CX";
            this.CX.Size = new System.Drawing.Size(13, 13);
            this.CX.TabIndex = 13;
            this.CX.Text = "0";
            // 
            // DX
            // 
            this.DX.AutoSize = true;
            this.DX.Location = new System.Drawing.Point(121, 770);
            this.DX.Name = "DX";
            this.DX.Size = new System.Drawing.Size(13, 13);
            this.DX.TabIndex = 12;
            this.DX.Text = "0";
            // 
            // AL
            // 
            this.AL.AutoSize = true;
            this.AL.Location = new System.Drawing.Point(243, 94);
            this.AL.Name = "AL";
            this.AL.Size = new System.Drawing.Size(13, 13);
            this.AL.TabIndex = 10;
            this.AL.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "AX";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // BL
            // 
            this.BL.AutoSize = true;
            this.BL.Location = new System.Drawing.Point(243, 288);
            this.BL.Name = "BL";
            this.BL.Size = new System.Drawing.Size(13, 13);
            this.BL.TabIndex = 7;
            this.BL.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "BX";
            // 
            // CL
            // 
            this.CL.AutoSize = true;
            this.CL.Location = new System.Drawing.Point(243, 515);
            this.CL.Name = "CL";
            this.CL.Size = new System.Drawing.Size(13, 13);
            this.CL.TabIndex = 4;
            this.CL.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 515);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "CX";
            // 
            // DL
            // 
            this.DL.AutoSize = true;
            this.DL.Location = new System.Drawing.Point(243, 770);
            this.DL.Name = "DL";
            this.DL.Size = new System.Drawing.Size(13, 13);
            this.DL.TabIndex = 1;
            this.DL.Text = "0";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox1.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX"});
            this.comboBox1.Location = new System.Drawing.Point(196, 376);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "AX";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Zatwierdź";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(342, 376);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // comboBoxOD
            // 
            this.comboBoxOD.FormattingEnabled = true;
            this.comboBoxOD.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX"});
            this.comboBoxOD.Location = new System.Drawing.Point(196, 519);
            this.comboBoxOD.Name = "comboBoxOD";
            this.comboBoxOD.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOD.TabIndex = 7;
            this.comboBoxOD.Text = "AX";
            // 
            // comboBoxDO
            // 
            this.comboBoxDO.FormattingEnabled = true;
            this.comboBoxDO.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX"});
            this.comboBoxDO.Location = new System.Drawing.Point(351, 519);
            this.comboBoxDO.Name = "comboBoxDO";
            this.comboBoxDO.Size = new System.Drawing.Size(111, 21);
            this.comboBoxDO.TabIndex = 8;
            this.comboBoxDO.Text = "AX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "MOV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "TO";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 567);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Zatwiedź";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TempTExt
            // 
            this.TempTExt.Location = new System.Drawing.Point(529, 519);
            this.TempTExt.Name = "TempTExt";
            this.TempTExt.Size = new System.Drawing.Size(100, 20);
            this.TempTExt.TabIndex = 12;
            this.TempTExt.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 851);
            this.Controls.Add(this.TempTExt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDO);
            this.Controls.Add(this.comboBoxOD);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Emulator";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label BL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label CL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label DL;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label AX;
        private System.Windows.Forms.Label BX;
        private System.Windows.Forms.Label CX;
        private System.Windows.Forms.Label DX;
        private System.Windows.Forms.ComboBox comboBoxOD;
        private System.Windows.Forms.ComboBox comboBoxDO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TempTExt;
    }
}

