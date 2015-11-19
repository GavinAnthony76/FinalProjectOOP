using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalProjectOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox2.Items.Insert(0, "Joe Temte");
            comboBox2.Items.Insert(1, "Jessica Livingston");
            comboBox2.Items.Insert(2, "Gavin Anthony");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Date = textBox8.Text;
            string Time = textBox7.Text;
            string Type = comboBox1.Text;
            string Fname = textBox3.Text;
            string Lname = textBox4.Text;
            string Pnum = textBox5.Text;
            string Email = textBox6.Text;
            string Problem = textBox1.Text;
            string Resolution = textBox2.Text;
            string Tech = comboBox2.Text;
            int ID = 00002;

            File.WriteAllText(ID +".txt", Date + Environment.NewLine + Time + Environment.NewLine + Type + Environment.NewLine + Fname + Environment.NewLine + Lname + Environment.NewLine + Pnum + Environment.NewLine + Email + Environment.NewLine + Problem + Environment.NewLine + Resolution + Environment.NewLine + Tech + Environment.NewLine + ID);
        }
    }
}
