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
        string[,] Podzial = new string[4, 2];
        static bool OnlyHexInString(string test)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(test, @"\A\b[0-9a-fA-F]+\b\Z");
        }

        public void Update_Display()
        {
            AX.Text = Convert.ToString(Zmienne[0]);
            AL.Text = Convert.ToString(Zmienne[0], 16);

            BX.Text = Convert.ToString(Zmienne[1]);
            BL.Text = Convert.ToString(Zmienne[1], 16);

            CX.Text = Convert.ToString(Zmienne[2]);
            CL.Text = Convert.ToString(Zmienne[2], 16);

            DX.Text = Convert.ToString(Zmienne[3]);
            DL.Text = Convert.ToString(Zmienne[3], 16);
            Fill();
            Split_Variables();
        }
        public void Fill()
        {
            for (; AL.Text.Length + BL.Text.Length + CL.Text.Length + DL.Text.Length < 16;)
            {
                if (AL.Text.Length < 4)
                    AL.Text = "0" + AL.Text;

                if (BL.Text.Length < 4)
                    BL.Text = "0" + BL.Text;

                if (CL.Text.Length < 4)
                    CL.Text = "0" + CL.Text;

                if (DL.Text.Length < 4)
                    DL.Text = "0" + DL.Text;
            }
        }
        public void Split_Variables()
        {
            label8.Text = AL.Text.Remove(0, 2);
            label14.Text = AL.Text.Remove(2, 2);
            label10.Text = BL.Text.Remove(0, 2);
            label15.Text = BL.Text.Remove(2, 2);
            label11.Text = CL.Text.Remove(0, 2);
            label16.Text = CL.Text.Remove(2, 2);
            label13.Text = DL.Text.Remove(0, 2);
            label17.Text = DL.Text.Remove(2, 2);
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

        private void button1_Click_1(object sender, EventArgs e) //sett
        {

            if (comboBox1.Items.Contains(comboBox1.Text))
            {
                if (OnlyHexInString(numericUpDown1.Text))
                {
                    string wybrane = comboBox1.SelectedItem.ToString();
                    if (Convert.ToInt32(numericUpDown1.Text, 16) < 65536)
                    {
                        Update_Variables(Convert.ToInt32(numericUpDown1.Text,16), wybrane);
                        Update_Display();
                    }
                    else
                        MessageBox.Show("Zbyt duża liczba!");
                }
                else
                    MessageBox.Show("Nieprawidłowy formtat liczby!");
            }
            else
                MessageBox.Show("Wybierz poprawny cel z listy!!!");
        }

        private void button2_Click(object sender, EventArgs e) //MOVE
        {
            if (comboBoxOD.Items.Contains(comboBoxOD.Text) && comboBoxDO.Items.Contains(comboBoxDO.Text))
            {
                if (comboBoxOD.SelectedItem != comboBoxDO.SelectedItem)
                {
                    int temp = Zmienne[Text_To_Int(comboBoxDO.SelectedItem.ToString())];
                    //Update_Variables(0, comboBoxDO.SelectedItem.ToString());
                    Update_Variables(temp, comboBoxOD.SelectedItem.ToString());
                    Update_Display();
                }
                else
                    MessageBox.Show("Cele muszą być różne!!!");
            }
        }

        private void button3_Click(object sender, EventArgs e) //EXCH
        {
            if (comboBoxFrom.Items.Contains(comboBoxFrom.Text) && comboBoxTo.Items.Contains(comboBoxTo.Text))
            {
                if (comboBoxFrom.SelectedItem != comboBoxTo.SelectedItem)
                {
                    int temp = Zmienne[Text_To_Int(comboBoxTo.SelectedItem.ToString())];
                    Update_Variables(Zmienne[Text_To_Int(comboBoxFrom.SelectedItem.ToString())], comboBoxTo.SelectedItem.ToString());
                    Update_Variables(temp, comboBoxFrom.SelectedItem.ToString());
                    Update_Display();
                }
                else
                    MessageBox.Show("Cele muszą być różne!!!");
            }
        }

        private void button_Random_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int temp;
            for (int i = 0; i < 4; i++)
            {
                temp = rand.Next(0, 65536);
                Zmienne[i] = temp;
            }
            Update_Display();
        }

        private void button5_Reset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                Zmienne[i] = 0;
            }
            Update_Display();
        }
    }
}

