using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z7_WinForms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            var font = fontDialog1.Font;
            var color = fontDialog1.Color;
            richTextBox1.Font = font;
            richTextBox1.ForeColor = color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
            var result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                button2.BackColor = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.ShowDialog();
            richTextBox1.Text = form2.text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }
    }
}
