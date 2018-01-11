using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2sem1
{
    public partial class FormParking : Form
    {
        Parking parking;

        public FormParking()
        {
            InitializeComponent();
            parking = new Parking();
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var rock = new Rock(100, 5, 200, dialog.Color);
                int place = parking.PutRockInParking(rock);
                Draw();
                MessageBox.Show("Ваша полка: " + place);
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
                    var rock = new Diamond(100, 5, 200, Color.Brown, true, true, dialogDop.Color);
                    int place = parking.PutRockInParking(rock);
                    Draw();
                    MessageBox.Show("Ваша полка: " + place);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(maskedTextBox1.Text != "")
            {
                var rock = parking.GetRockInParking(Convert.ToInt32(maskedTextBox1.Text));
                Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                Graphics gr = Graphics.FromImage(bmp);
                rock.setPosition(15, 15);
                rock.drawRock(gr);
                pictureBox2.Image = bmp;
                Draw();
            }
        }
    }
}