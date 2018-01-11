using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2sem1
{
    public abstract class RockFormation : IRock
    {
        public virtual void setMainColor(Color color)
        {
            ColorBody = color;
        }

        protected float startPosX;

        protected float startPosY;

        protected int weightDiam;

        public virtual int MaxRockWeight { protected set; get; }

        public virtual int MaxKarat { protected set; get; }

        public Color ColorBody { protected set; get; }

        public virtual double Weight { protected set; get; }

        public abstract void treatmentRock(Graphics g);

        public abstract void drawRock(Graphics g);

        public void setPosition(int x, int y)
        {
            startPosX = x;
            startPosY = y;
        }

        public void weightDiamond(int weight)
        {
            if (weightDiam + weight < MaxRockWeight)
            {
                weightDiam += weight;
            }
        }

        public int getDiamond()
        {
            int weight = weightDiam;
            weightDiam = 0;
            return weight;
        }

        public abstract string getInfo();
    }
}
