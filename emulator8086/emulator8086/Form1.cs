using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace emulator8086
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "text";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (comboBox1.Items.Contains(comboBox1.Text))
            {
                string wybrane = comboBox1.SelectedItem.ToString();
                if (numericUpDown1.Value < 65536)
                {
                    if (wybrane == "AX")
                    {
                        AX.Text = numericUpDown1.Text;
                        AL.Text = Convert.ToString(Convert.ToInt32(numericUpDown1.Value), 2);
                    }
                    if (wybrane == "BX")
                    {
                        BX.Text = numericUpDown1.Text;
                        BL.Text = Convert.ToString(Convert.ToInt32(numericUpDown1.Value), 2);
                    }
                    if (wybrane == "CX")
                    {
                        CX.Text = numericUpDown1.Text;
                        CL.Text = Convert.ToString(Convert.ToInt32(numericUpDown1.Value), 2);
                    }
                    if (wybrane == "DX")
                    {
                        DX.Text = numericUpDown1.Text;
                        DL.Text = Convert.ToString(Convert.ToInt32(numericUpDown1.Value), 2);
                    }

                }
                else
                    MessageBox.Show("Zbyt duża liczba");
            }
            else
                MessageBox.Show("Wybierz poprawny cel z listy!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxOD.Items.Contains(comboBoxOD.Text)&& comboBoxDO.Items.Contains(comboBoxDO.Text))
            {
                if (comboBoxOD.SelectedItem != comboBoxDO.SelectedItem) 
                { 
                    string wybraneOD = comboBoxOD.SelectedItem.ToString();
                    string wybraneDO = comboBoxDO.SelectedItem.ToString();

                    if (wybraneOD == "AX")
                    {
                        TempTExt.Text = AX.Text;
                        AX.Text = "0";
                        AL.Text = "0";
                    }
                    if (wybraneOD == "BX")
                    {
                        TempTExt.Text = BX.Text;
                        BX.Text = "0";
                        BL.Text = "0";
                    }
                    if (wybraneOD == "CX")
                    {
                        TempTExt.Text = CX.Text;
                        CX.Text = "0";
                        CL.Text = "0";
                    }
                    if (wybraneOD == "DX")
                    {
                        TempTExt.Text = DX.Text;
                        DX.Text = "0";
                        DL.Text = "0";
                    }
                    if (wybraneDO == "AX")
                    {
                        AX.Text = TempTExt.Text;
                        AL.Text = Convert.ToString(Convert.ToInt32(AX.Text), 2);
                    }
                    if (wybraneDO == "BX")
                    {
                        BX.Text = TempTExt.Text;
                        BL.Text = Convert.ToString(Convert.ToInt32(BX.Text), 2);
                    }
                    if (wybraneDO == "CX")
                    {
                        CX.Text = TempTExt.Text;
                        CL.Text = Convert.ToString(Convert.ToInt32(CX.Text), 2);
                    }
                    if (wybraneDO == "DX")
                    {
                        DX.Text = TempTExt.Text;
                        DL.Text = Convert.ToString(Convert.ToInt32(DX.Text), 2);
                    }
                }
                else
                    MessageBox.Show("Cele muszą być różne!!!");


            }
        }


    }
}

