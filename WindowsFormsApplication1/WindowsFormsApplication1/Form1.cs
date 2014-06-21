using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Kwadrat kwadrat1 = new Kwadrat();
            int a = (int)numericUpDown1.Value;
            MessageBox.Show("Wynik: " + kwadrat1.poleKwadratu(a));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prostokat prostokat1 = new Prostokat();
            int a = (int)numericUpDown2.Value;
            int b = (int)numericUpDown3.Value;
            MessageBox.Show("Wynik: " + prostokat1.poleProstokatu(a, b));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Trojkat trojkat1 = new Trojkat();
            int a = (int)numericUpDown4.Value;
            int h = (int)numericUpDown5.Value;
            MessageBox.Show("Wynik: " + trojkat1.poleTrojkat(a, h));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Okrag okrag1 = new Okrag();
            int a = (int)numericUpDown6.Value;
            MessageBox.Show("Wynik: " + okrag1.poleOkregu(a));

        }

        
    }
}
