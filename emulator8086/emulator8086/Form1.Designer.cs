
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.AH_L = new System.Windows.Forms.Label();
            this.BH_L = new System.Windows.Forms.Label();
            this.CH_L = new System.Windows.Forms.Label();
            this.DH_L = new System.Windows.Forms.Label();
            this.AL_L = new System.Windows.Forms.Label();
            this.BL_L = new System.Windows.Forms.Label();
            this.CL_L = new System.Windows.Forms.Label();
            this.DL_L = new System.Windows.Forms.Label();
            this.AL = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BL = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DL = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxOD = new System.Windows.Forms.ComboBox();
            this.comboBoxDO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_Random = new System.Windows.Forms.Button();
            this.button5_Reset = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DX";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.AH_L);
            this.panel1.Controls.Add(this.BH_L);
            this.panel1.Controls.Add(this.CH_L);
            this.panel1.Controls.Add(this.DH_L);
            this.panel1.Controls.Add(this.AL_L);
            this.panel1.Controls.Add(this.BL_L);
            this.panel1.Controls.Add(this.CL_L);
            this.panel1.Controls.Add(this.DL_L);
            this.panel1.Controls.Add(this.AL);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.BL);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.CL);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.DL);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(601, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 313);
            this.panel1.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(305, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 13);
            this.label19.TabIndex = 25;
            this.label19.Text = "LOW";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(350, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "HIGH";
            // 
            // AH_L
            // 
            this.AH_L.AutoSize = true;
            this.AH_L.Location = new System.Drawing.Point(357, 93);
            this.AH_L.Name = "AH_L";
            this.AH_L.Size = new System.Drawing.Size(19, 13);
            this.AH_L.TabIndex = 23;
            this.AH_L.Text = "00";
            // 
            // BH_L
            // 
            this.BH_L.AutoSize = true;
            this.BH_L.Location = new System.Drawing.Point(357, 145);
            this.BH_L.Name = "BH_L";
            this.BH_L.Size = new System.Drawing.Size(19, 13);
            this.BH_L.TabIndex = 22;
            this.BH_L.Text = "00";
            // 
            // CH_L
            // 
            this.CH_L.AutoSize = true;
            this.CH_L.Location = new System.Drawing.Point(357, 200);
            this.CH_L.Name = "CH_L";
            this.CH_L.Size = new System.Drawing.Size(19, 13);
            this.CH_L.TabIndex = 21;
            this.CH_L.Text = "00";
            // 
            // DH_L
            // 
            this.DH_L.AutoSize = true;
            this.DH_L.Location = new System.Drawing.Point(357, 252);
            this.DH_L.Name = "DH_L";
            this.DH_L.Size = new System.Drawing.Size(19, 13);
            this.DH_L.TabIndex = 20;
            this.DH_L.Text = "00";
            // 
            // AL_L
            // 
            this.AL_L.AutoSize = true;
            this.AL_L.Location = new System.Drawing.Point(311, 93);
            this.AL_L.Name = "AL_L";
            this.AL_L.Size = new System.Drawing.Size(19, 13);
            this.AL_L.TabIndex = 19;
            this.AL_L.Text = "00";
            // 
            // BL_L
            // 
            this.BL_L.AutoSize = true;
            this.BL_L.Location = new System.Drawing.Point(311, 145);
            this.BL_L.Name = "BL_L";
            this.BL_L.Size = new System.Drawing.Size(19, 13);
            this.BL_L.TabIndex = 18;
            this.BL_L.Text = "00";
            // 
            // CL_L
            // 
            this.CL_L.AutoSize = true;
            this.CL_L.Location = new System.Drawing.Point(311, 200);
            this.CL_L.Name = "CL_L";
            this.CL_L.Size = new System.Drawing.Size(19, 13);
            this.CL_L.TabIndex = 17;
            this.CL_L.Text = "00";
            // 
            // DL_L
            // 
            this.DL_L.AutoSize = true;
            this.DL_L.Location = new System.Drawing.Point(311, 252);
            this.DL_L.Name = "DL_L";
            this.DL_L.Size = new System.Drawing.Size(19, 13);
            this.DL_L.TabIndex = 16;
            this.DL_L.Text = "00";
            // 
            // AL
            // 
            this.AL.AutoSize = true;
            this.AL.Location = new System.Drawing.Point(243, 94);
            this.AL.Name = "AL";
            this.AL.Size = new System.Drawing.Size(31, 13);
            this.AL.TabIndex = 10;
            this.AL.Text = "0000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(189, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "AX";
            // 
            // BL
            // 
            this.BL.AutoSize = true;
            this.BL.Location = new System.Drawing.Point(243, 146);
            this.BL.Name = "BL";
            this.BL.Size = new System.Drawing.Size(31, 13);
            this.BL.TabIndex = 7;
            this.BL.Text = "0000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(189, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "BX";
            // 
            // CL
            // 
            this.CL.AutoSize = true;
            this.CL.Location = new System.Drawing.Point(243, 201);
            this.CL.Name = "CL";
            this.CL.Size = new System.Drawing.Size(31, 13);
            this.CL.TabIndex = 4;
            this.CL.Text = "0000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "CX";
            // 
            // DL
            // 
            this.DL.AutoSize = true;
            this.DL.Location = new System.Drawing.Point(243, 253);
            this.DL.Name = "DL";
            this.DL.Size = new System.Drawing.Size(31, 13);
            this.DL.TabIndex = 1;
            this.DL.Text = "0000";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox1.Items.AddRange(new object[] {
            "AL",
            "AH",
            "BL",
            "BH",
            "CL",
            "CH",
            "DL",
            "DH",
            "AX",
            "BX",
            "CX",
            "DX"});
            this.comboBox1.Location = new System.Drawing.Point(225, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "AL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Zatwierdź";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBoxOD
            // 
            this.comboBoxOD.FormattingEnabled = true;
            this.comboBoxOD.Items.AddRange(new object[] {
            "AL",
            "AH",
            "BL",
            "BH",
            "CL",
            "CH",
            "DL",
            "DH",
            "AX",
            "BX",
            "CX",
            "DX"});
            this.comboBoxOD.Location = new System.Drawing.Point(225, 250);
            this.comboBoxOD.Name = "comboBoxOD";
            this.comboBoxOD.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOD.TabIndex = 7;
            this.comboBoxOD.Text = "AL";
            // 
            // comboBoxDO
            // 
            this.comboBoxDO.FormattingEnabled = true;
            this.comboBoxDO.Items.AddRange(new object[] {
            "AL",
            "AH",
            "BL",
            "BH",
            "CL",
            "CH",
            "DL",
            "DH",
            "AX",
            "BX",
            "CX",
            "DX"});
            this.comboBoxDO.Location = new System.Drawing.Point(380, 250);
            this.comboBoxDO.Name = "comboBoxDO";
            this.comboBoxDO.Size = new System.Drawing.Size(111, 21);
            this.comboBoxDO.TabIndex = 8;
            this.comboBoxDO.Text = "AH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "MOV";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Zatwiedź";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(380, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Zatwiedź";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "TO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "EXC";
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Items.AddRange(new object[] {
            "AL",
            "AH",
            "BL",
            "BH",
            "CL",
            "CH",
            "DL",
            "DH",
            "AX",
            "BX",
            "CX",
            "DX"});
            this.comboBoxTo.Location = new System.Drawing.Point(380, 384);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(111, 21);
            this.comboBoxTo.TabIndex = 13;
            this.comboBoxTo.Text = "AH";
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Items.AddRange(new object[] {
            "AL",
            "AH",
            "BL",
            "BH",
            "CL",
            "CH",
            "DL",
            "DH",
            "AX",
            "BX",
            "CX",
            "DX"});
            this.comboBoxFrom.Location = new System.Drawing.Point(225, 384);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFrom.TabIndex = 12;
            this.comboBoxFrom.Text = "AL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "SET";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(380, 107);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 18;
            // 
            // button_Random
            // 
            this.button_Random.Location = new System.Drawing.Point(225, 496);
            this.button_Random.Name = "button_Random";
            this.button_Random.Size = new System.Drawing.Size(75, 23);
            this.button_Random.TabIndex = 19;
            this.button_Random.Text = "Random";
            this.button_Random.UseVisualStyleBackColor = true;
            this.button_Random.Click += new System.EventHandler(this.button_Random_Click);
            // 
            // button5_Reset
            // 
            this.button5_Reset.Location = new System.Drawing.Point(380, 495);
            this.button5_Reset.Name = "button5_Reset";
            this.button5_Reset.Size = new System.Drawing.Size(75, 23);
            this.button5_Reset.TabIndex = 20;
            this.button5_Reset.Text = "Reset";
            this.button5_Reset.UseVisualStyleBackColor = true;
            this.button5_Reset.Click += new System.EventHandler(this.button5_Reset_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.label20.Location = new System.Drawing.Point(336, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(350, 44);
            this.label20.TabIndex = 21;
            this.label20.Text = "Emulator Intel 8086";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 568);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.button5_Reset);
            this.Controls.Add(this.button_Random);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxTo);
            this.Controls.Add(this.comboBoxFrom);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDO);
            this.Controls.Add(this.comboBoxOD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Emulator";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBoxOD;
        private System.Windows.Forms.ComboBox comboBoxDO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numericUpDown1;
        private System.Windows.Forms.Label AH_L;
        private System.Windows.Forms.Label BH_L;
        private System.Windows.Forms.Label CH_L;
        private System.Windows.Forms.Label DH_L;
        private System.Windows.Forms.Label AL_L;
        private System.Windows.Forms.Label BL_L;
        private System.Windows.Forms.Label CL_L;
        private System.Windows.Forms.Label DL_L;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_Random;
        private System.Windows.Forms.Button button5_Reset;
        private System.Windows.Forms.Label label20;
    }
}

