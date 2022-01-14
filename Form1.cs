using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lommeregner
{
    public partial class Form1 : Form
    {
        String operation = "";
        Double firstnum, secondnum;

        public Form1()
        {
            InitializeComponent();
        }

        private void NumericValue(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (textBox1.Text == "0")
                textBox1.Text = "";

            if(b.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + b.Text;
            }

            else
            {
                textBox1.Text = textBox1.Text + b.Text;
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";

            String f, s;

            s = Convert.ToString(secondnum);
            f = Convert.ToString(firstnum);

            s = "";
            f = "";
        }

        private void Operational_Function(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            firstnum = Double.Parse(textBox1.Text);
            operation = b.Text;
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }

            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Contains("-"))
            {
                textBox1.Text = textBox1.Text.Remove(0, 1);
            }

            else
            {
                textBox1.Text = "-" + textBox1.Text;
            }
                


        }

        private void button18_Click(object sender, EventArgs e)
        {
            secondnum = Double.Parse(textBox1.Text);

            switch (operation)
            {
                case "+":
                    textBox1.Text = Convert.ToString(firstnum + secondnum);
                    break;
                case "-":
                    textBox1.Text = Convert.ToString(firstnum - secondnum);
                    break;
                case "*":
                    textBox1.Text = Convert.ToString(firstnum * secondnum);
                    break;
                case "/":
                    textBox1.Text = Convert.ToString(firstnum / secondnum);
                    break;
                default:
                    break;



            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
