using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextLabelNUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(Int64.TryParse(textBox1.Text, out Int64 value))
            {
                if (numericUpDown1.Maximum < value)
                {
                    numericUpDown1.Maximum = value;
                }
                numericUpDown1.Value = value;
                
                if(textBox1.Text == "")
                {
                    numericUpDown1.Value = 0;
                    numericUpDown1.Maximum = 1;
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = numericUpDown1.Value.ToString();
        }
    }
}
