using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Vozidla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Vozidlo vozidlo;
        Autobus autobus;
        private void button1_Click(object sender, EventArgs e)
        {
            vozidlo = new Vozidlo(textBox1.Text, double.Parse(textBox2.Text), int.Parse(textBox3.Text), double.Parse(textBox4.Text));
            MessageBox.Show(vozidlo.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            autobus = new Autobus(textBox1.Text, double.Parse(textBox2.Text), int.Parse(textBox3.Text), double.Parse(textBox4.Text), int.Parse(textBox5.Text), int.Parse(textBox6.Text));
            MessageBox.Show(autobus.ToString());
            MessageBox.Show("Vydelek z cesty cini " + autobus.Vydelek());
        }
    }
}
