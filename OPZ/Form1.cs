using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Visible = false;
            textBox3.Visible = false;
            textBox2.Visible = false;
            textBox1.Focus();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox2.Text = "";
            string enter = textBox1.Text;
            if (enter == "")
            {
                MessageBox.Show("Введите выражение");
                return;
            }
            char[] char1 = enter.ToArray();
            int tOp = 0;
            int tCl = 0;
            for (int j = 0; j < enter.Length; j++)
            {
                if (enter[j] == '(')
                {
                    tOp++;
                }
            }
            for (int k = 0; k < enter.Length; k++)
            {
                if (enter[k] == ')')
                {
                    tCl++;
                }
            }
            if (tCl != tOp)
            {
                MessageBox.Show("Введите выражение корректно");
                return;
            }
            button2.Visible = true;
            if (textBox1.Text.Any(char.IsLetter))
            {
                button2.Visible = false;
                textBox3.Visible = false;
            }
            textBox2.Text += ToOpz.OPZConv(enter);
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.Text += Calc.IzOPZ(textBox2.Text);
            textBox3.Visible = true;
            if (textBox3.Text==0.ToString())
            {
                textBox3.Text = "";
                MessageBox.Show("Деление на 0");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox3.Visible = false;
            textBox2.Visible = false;
            button2.Visible = false;
            textBox1.Focus();
        }
    }
}
