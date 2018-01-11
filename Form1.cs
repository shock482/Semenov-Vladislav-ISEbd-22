using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2sem1
{
    public partial class Form1 : Form
    {
        Color color;
        Color dopColor;
        int weight;
        int maxKarat;
        int maxRockWeight;
        private IRock inter;

        public Form1()
        {
            InitializeComponent();

            color = Color.Brown;
            dopColor = Color.Green;
            weight = 5000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = cd.Color;
                button1.BackColor = color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dopColor = cd.Color;
                button2.BackColor = dopColor;
            }
        }

        private bool checkFields()
        {
            if(!int.TryParse(textBox1.Text, out maxKarat))
            {
                return false;
            }
            if (!int.TryParse(textBox2.Text, out maxRockWeight))
            {
                return false;
            }
            if (!int.TryParse(textBox3.Text, out weight))
            {
                return false;
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new Rock(maxKarat, maxRockWeight, weight, Color.Brown);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.drawRock(gr);
                pictureBox1.Image = bmp;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new Diamond(maxKarat, maxRockWeight, weight, Color.Aqua, checkBox2.Checked, checkBox3.Checked, dopColor);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.drawRock(gr);
                pictureBox1.Image = bmp;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (inter != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.drawRock(gr);
                pictureBox1.Image = bmp;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
