using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab2sem1.RockFormation;

namespace lab2sem1
{
    class Rock : RockFormation
    {

        public override int MaxKarat
        {
            get
            {
                return base.MaxKarat;
            }
            protected set
            {
                if (value > 0 && value < 7000)
                {
                    base.MaxKarat = value;
                }
                else
                {
                    base.MaxKarat = 100;
                }
            }
        }

        public override int MaxRockWeight
        {
            get
            {
                return base.MaxRockWeight;
            }
            protected set
            {
                if (value > 0 && value < 7)
                {
                    base.MaxRockWeight = value;
                }
                else
                {
                    base.MaxRockWeight = 5;
                }
            }
        }

   

        public override double Weight
        {
            get
            {
                return base.Weight;
            }
            protected set
            {
                if(value > 100 && value < 10000)
                {
                    base.Weight = value;
                }
                else
                {
                    base.Weight = 5000;
                }
            }
        }

   

        public Rock(int maxKarat, int maxRockWeight, double weight, Color color)
        {
            this.MaxKarat = maxKarat;
            this.MaxRockWeight = maxRockWeight;
            this.ColorBody = color;
            this.Weight = weight;
            this.weightDiam = 0;
            Random rand = new Random();
            startPosX = rand.Next(10, 200);
            startPosY = rand.Next(10, 200);
        }

        public override void treatmentRock(Graphics g)
        {
            drawRock(g);
        }

        public override void drawRock(Graphics g)
        {
            drawrock(g);
        }

        protected virtual void drawrock(Graphics g)
        {
            Pen penB = new Pen(ColorBody);
            Pen penY = new Pen(Color.Yellow);
            Brush brushB = new SolidBrush(Color.Brown);
            Brush brushY = new SolidBrush(Color.Yellow);

            g.DrawRectangle(penB, startPosX + 10, startPosY + 30, 30, 30);
            g.DrawLine(penB, startPosX + 10, startPosY + 30, startPosX + 25, startPosY + 10);
            g.DrawLine(penB, startPosX + 25, startPosY + 10, startPosX + 40, startPosY + 30);
            g.DrawLine(penB, startPosX + 40, startPosY + 30, startPosX + 50, startPosY + 45);
            g.DrawLine(penB, startPosX + 50, startPosY + 45, startPosX + 40, startPosY + 60);
            g.DrawLine(penB, startPosX + 40, startPosY + 60, startPosX + 25, startPosY + 73);
            g.DrawLine(penB, startPosX + 25, startPosY + 73, startPosX + 10, startPosY + 60);
            g.DrawLine(penB, startPosX + 10, startPosY + 60, startPosX - 5, startPosY + 45);
            g.DrawLine(penB, startPosX - 5, startPosY + 45, startPosX + 10, startPosY + 30);
        }
    }
}
