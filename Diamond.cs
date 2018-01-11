using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2sem1
{
    class Diamond : Rock
    {

        private bool inclusions;

        private bool glow;

        private Color dopColor;
        public Color color;

        public void setDopColor(Color color)
        {
            dopColor = color;
        }

        public Diamond(int maxKarat, int maxRockWeight, double weight, Color color, bool inclusions, bool glow, Color dopColor) : 
            base(maxKarat, maxRockWeight, weight, color)
        {
            this.inclusions = inclusions;
            this.glow = glow;
            this.dopColor = dopColor;
            this.color = color;
        }

        protected override void drawrock(Graphics g)
        {
           if (inclusions)
            {
                Pen penY = new Pen(dopColor);
                Pen penB = new Pen(color);
                Brush brushB = new SolidBrush(dopColor);
                Brush brushY = new SolidBrush(Color.Yellow);
                Brush brushG = new SolidBrush(Color.Green);
                Brush brushD = new SolidBrush(dopColor);

                g.DrawEllipse(penY, startPosX + 10, startPosY + 40, 5, 5);
                g.DrawEllipse(penY, startPosX + 13, startPosY + 35, 5, 5);            
                g.DrawEllipse(penY, startPosX + 5, startPosY + 30, 5, 5);
                g.DrawEllipse(penY, startPosX + 20, startPosY + 25, 5, 5);
                g.DrawEllipse(penY, startPosX + 41, startPosY + 50, 5, 5);
                g.FillEllipse(brushG, startPosX + 48, startPosY + 45, 5, 5);
                g.FillEllipse(brushD, startPosX + 31, startPosY + 20, 5, 5);
                g.FillEllipse(brushB, startPosX + 20, startPosY + 15, 5, 5);
                g.FillEllipse(brushD, startPosX + 8, startPosY + 35, 5, 5);
                g.FillEllipse(brushY, startPosX + 21, startPosY + 25, 5, 5);
                g.FillEllipse(brushD, startPosX + 18, startPosY + 45, 5, 5);
                g.DrawRectangle(penB, startPosX + 11, startPosY + 31, 31, 31);
                g.DrawLine(penB, startPosX + 11, startPosY + 31, startPosX + 26, startPosY + 11);
                g.DrawLine(penB, startPosX + 26, startPosY + 11, startPosX + 41, startPosY + 31);
                g.DrawLine(penB, startPosX + 41, startPosY + 31, startPosX + 51, startPosY + 46);
                g.DrawLine(penB, startPosX + 51, startPosY + 46, startPosX + 41, startPosY + 61);
                g.DrawLine(penB, startPosX + 41, startPosY + 61, startPosX + 26, startPosY + 74);
                g.DrawLine(penB, startPosX + 26, startPosY + 74, startPosX + 11, startPosY + 61);
                g.DrawLine(penB, startPosX + 11, startPosY + 61, startPosX - 4, startPosY + 46);
                g.DrawLine(penB, startPosX - 4, startPosY + 46, startPosX + 11, startPosY + 31);
            }

           if (glow)
            {
                Pen penB = new Pen(dopColor);
                g.DrawLine(penB, startPosX, startPosY, startPosX - 25, startPosY + 30);
                g.DrawLine(penB, startPosX + 15, startPosY + 17, startPosX - 45, startPosY - 50);
                g.DrawLine(penB, startPosX + 70, startPosY + 15, startPosX + 30, startPosY + 59);
                g.DrawLine(penB, startPosX + 50, startPosY + 30, startPosX + 65, startPosY + 45);
            }
            base.drawrock(g);
        }
    }
}
