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
        int[] Zmienne = new int[4];

        public void Update_Display()
        {
            AX.Text = Convert.ToString(Zmienne[0]);
            AL.Text = Convert.ToString(Convert.ToInt32(Zmienne[0]), 2);

            BX.Text = Convert.ToString(Zmienne[1]);
            BL.Text = Convert.ToString(Convert.ToInt32(Zmienne[1]), 2);

            CX.Text = Convert.ToString(Zmienne[2]);
            CL.Text = Convert.ToString(Convert.ToInt32(Zmienne[2]), 2);

            DX.Text = Convert.ToString(Zmienne[3]);
            DL.Text = Convert.ToString(Convert.ToInt32(Zmienne[3]), 2);
        }

        public void Update_Variables(int a, string b)
        {
            if (b == "AX")
            {
                Zmienne[0] = a;
            }
            if (b == "BX")
            {
                Zmienne[1] = a;
            }
            if (b == "CX")
            {
                Zmienne[2] = a;
            }
            if (b == "DX")
            {
                Zmienne[3] = a;
            }
        }

        public int Text_To_Int(string tak)
        {
            if (tak == "AX")
            {
                return (0);
            }
            if (tak == "BX")
            {
                return (1);
            }
            if (tak == "CX")
            {
                return (2);
            }
            if (tak == "DX")
            {
                return (3);
            }
            else
                return (0);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (comboBox1.Items.Contains(comboBox1.Text))
            {
                string wybrane = comboBox1.SelectedItem.ToString();
                if (numericUpDown1.Value < 65536)
                {
                    Update_Variables(Convert.ToInt32(numericUpDown1.Text), wybrane);
                    Update_Display();
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
                    int temp = Zmienne[Text_To_Int(comboBoxOD.SelectedItem.ToString())];
                    Update_Variables(0, comboBoxOD.SelectedItem.ToString());
                    Update_Variables(temp, comboBoxDO.SelectedItem.ToString());
                    Update_Display();
                }
                else
                    MessageBox.Show("Cele muszą być różne!!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBoxFrom.Items.Contains(comboBoxFrom.Text) && comboBoxTo.Items.Contains(comboBoxTo.Text))
            {
                if (comboBoxFrom.SelectedItem != comboBoxTo.SelectedItem)
                {
                    int temp = Zmienne[Text_To_Int(comboBoxFrom.SelectedItem.ToString())];
                    Update_Variables(Zmienne[Text_To_Int(comboBoxTo.SelectedItem.ToString())], comboBoxFrom.SelectedItem.ToString());
                    Update_Variables(temp, comboBoxTo.SelectedItem.ToString());
                    Update_Display();
                }
                else
                    MessageBox.Show("Cele muszą być różne!!!");
            }
        }
    }
}

