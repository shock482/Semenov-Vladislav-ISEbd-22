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
    public partial class FormSelectRock : Form
    {
        IRock rock = null;

        private IRock GetRock { get { return rock; } }

        public FormSelectRock()
        {
            InitializeComponent();

            panelBlack.MouseDown += panelColor_MouseDown;
            panelGold.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawRock()
        {
            if (rock != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxRock.Width, pictureBoxRock.Height);
                Graphics gr = Graphics.FromImage(bmp);
                rock.setPosition(5, 0);
                rock.drawRock(gr);
                pictureBoxRock.Image = bmp;
            }
        }

        private event myDel eventAddRock;

        public void AddEvent(myDel ev)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelRock_MouseDown(object sender, MouseEventArgs e)
        {
            labelRock.DoDragDrop(labelRock.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelRock_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Камень":
                    rock = new Rock(100, 5, 200, Color.Red);
                    break;
                case "Алмаз":
                    rock = new Diamond(100, 5, 200, Color.Red, true, true, Color.Black);
                    break;
            }
            DrawRock();
        }

        private void panelRock_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (rock != null)
            {
                rock.setMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawRock();
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (rock != null)
            {
                if (rock is Diamond)
                {
                    (rock as Diamond).setDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawRock();
                }
            }
        }

        private void buttonSetRock_Click(object sender, EventArgs e)
        {
            if (eventAddRock != null)
            {
                eventAddRock(rock);
            }
            Close();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            labelRock.DoDragDrop(labelRock.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelDIamond_MouseDown(object sender, MouseEventArgs e)
        {
            label2.DoDragDrop(label2.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelRock_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelBaseColor_Click(object sender, EventArgs e)
        {

        }
    }
}
