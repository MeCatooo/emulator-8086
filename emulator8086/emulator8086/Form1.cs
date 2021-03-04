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
    
    

        }
    }
 
