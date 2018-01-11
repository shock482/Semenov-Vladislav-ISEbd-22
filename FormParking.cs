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
    public partial class FormParking : Form
    {

        Parking parking;
        FormSelectRock form;

        public FormParking()
        {
            InitializeComponent();
            parking = new Parking(5);

            for (int i = 1; i < 6; i++)
            {
                listBox1.Items.Add("Уровень " + i);
            }
            listBox1.SelectedIndex = parking.getCurrentLevel;
            Draw();
        }

        private void Draw()
        {
            if (listBox1.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking.Draw(gr);
                pictureBox1.Image = bmp;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddRock(IRock rock)
        {
            if (rock != null)
            {
                int place = parking.PutRockInParking(rock);
                if (place > -1)
                {
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
                else
                {
                    MessageBox.Show("Камень не удалось положить");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var rock = new Diamond(100, 5, 200, dialog.Color, true, true, dialogDop.Color);
                    int place = parking.PutRockInParking(rock);
                    Draw();
                    MessageBox.Show("Ваша полка: " + place);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                string level = listBox1.Items[listBox1.SelectedIndex].ToString();
                if (maskedTextBox1.Text != "")
                {
                    IRock rock = parking.GetRockInParking(Convert.ToInt32(maskedTextBox1.Text));
                    if (rock != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        rock.setPosition(15, 15);
                        rock.drawRock(gr);
                        pictureBox2.Image = bmp;
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Извините, на этом месте нет камня");
                    }
                }
            }        
        }

        private event myDel eventAddRock;

        private void AddEvent(myDel ev)
        {
            if (eventAddRock == null)
            {
                eventAddRock = new myDel(ev);
            }
            else
            {
                eventAddRock += ev;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            parking.LevelDown();
            listBox1.SelectedIndex = parking.getCurrentLevel;
            Draw();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            parking.LevelUp();
            listBox1.SelectedIndex = parking.getCurrentLevel;
            Draw();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            form = new FormSelectRock();
            form.AddEvent(AddRock);
            form.Show();
        }
    }
}