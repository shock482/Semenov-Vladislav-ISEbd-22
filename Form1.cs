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



  //      internal Knife Knife { get => knife; set => knife = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //knife = new Knife();
            //oven = new Oven();
            //ovenon = new OvenOn();
            //forma = new Forma();
           // miska = new Miska();
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
                for (int i = 0; i < apple.Length; ++i)
                {
                   // Knife.Cut(apple[i]);
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
            //eggs = new Eggs[Convert.ToInt32(numericUpDown4.Value)];
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
            //eggs = new Eggs[Convert.ToInt32(numericUpDown4.Value)];
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
            //eggs = new Eggs[Convert.ToInt32(numericUpDown4.Value)];
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
        {

        }
    }
}
