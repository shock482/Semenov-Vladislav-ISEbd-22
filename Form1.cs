using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1sem1
{
    public partial class Form1 : Form
    {

        private Apple[] apple;
        private Sugar sugar;
        private Knife knife = new Knife();
        private Miska miska = new Miska();
        private Eggs eggs;
        private Forma forma = new Forma();
        private Muka muka;
        private Oven oven = new Oven();
        private Testo testo;
        private OvenOn ovenon;
        namespace laba2sem1
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
            }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ovenon.State = checkBox1.Checked;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown2.Value >= 0)
            {
                apple = new Apple[Convert.ToInt32(numericUpDown2.Value)];
                for (int i = 0; i < apple.Length; ++i)
                {
                    apple[i] = new Apple();
                }
                if (apple.Length == null)
                {
                    MessageBox.Show("Яблок то нет!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (apple.Length == 0)
                {
                    MessageBox.Show("Яблок то нет!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                numericUpDown2.Enabled = false;
                button1.Enabled = true;
                MessageBox.Show("Порезали, можно кидать в форму", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);     
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            eggs = new Eggs();
            eggs.Count = Convert.ToInt32(numericUpDown4.Value);
            if (eggs.Count > 0)
            {
                miska.AddEggs(eggs);
                MessageBox.Show("Яица добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Яиц нет, что добавлять?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button5.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            muka = new Muka();
            muka.Count = Convert.ToInt32(numericUpDown1.Value);
            if (muka.Count > 0)
            {
                miska.AddMuka(muka);
                MessageBox.Show("Муку добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Муки нет, что добавлять?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button6.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sugar = new Sugar();
            sugar.Count = Convert.ToInt32(numericUpDown3.Value);
            if (sugar.Count > 0)
            {
                miska.AddSugar(sugar);
                MessageBox.Show("Сахар добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Сахара нет, что добавлять?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button7.Enabled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (muka == null)
            {
                MessageBox.Show("Муки нет, что смешивать?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sugar == null)
            {
                MessageBox.Show("Сахара нет, что смешивать?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (eggs == null)
            {
                MessageBox.Show("Яиц нет, что смешивать?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            miska.Mix (sugar, muka, eggs);
            MessageBox.Show("Смешали", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button12_Click(object sender, EventArgs e)
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
