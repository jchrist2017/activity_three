using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string answer = "";
        private void label1_Click(object sender, EventArgs e)
        {
            answer += "cf\n";
        }   

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            answer += "cf\n";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            answer += "valo\n";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            answer += "fota\n";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            answer += "dota1\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.ReadOnly == true)
            {
                MessageBox.Show("You selected\n" + answer);
            }
            else
            {
                MessageBox.Show("You selected\n" + textBox1.Text+ "\n"+ answer+"\nThank you");
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
