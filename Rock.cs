using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab2sem1.RockFormation;

namespace lab2sem1
{
    public class Rock : RockFormation, IComparable<Rock>, IEquatable<Rock>
    {
        public int CompareTo(Rock other)
        {
            if (other == null) {
                return 1;
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            
            if (MaxKarat != other.MaxKarat)
            {
                return MaxKarat.CompareTo(other.MaxKarat);
            }
            if (ColorBody != other.ColorBody)
            {
                return ColorBody.Name.CompareTo(other.ColorBody);
            }
            return 0;
        }

        public bool Equals(Rock other)
        {
            if (other == null)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MaxKarat != other.MaxKarat)
            {
                return false;
            }
            if (ColorBody != other.ColorBody)
            {
                return false;
            }
            return true;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Rock RockObj = obj as Rock;
            if (RockObj == null)
            {
                return false;
            }
            else
            {
                return Equals(RockObj);
            }       
        }
        public override int GetHashCode()
        {
            return MaxKarat.GetHashCode();
        }

        public Rock(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 4)
            {
                MaxKarat = Convert.ToInt32(strs[0]);
                MaxRockWeight = Convert.ToInt32(strs[1]);
                Weight = Convert.ToInt32(strs[2]);
                ColorBody = Color.FromName(strs[3]);
            }
            this.weightDiam = 0;
            Random rand = new Random();
            startPosX = rand.Next(10, 200);
            startPosY = rand.Next(10, 200);
        }

        public override string getInfo()
        {
            return MaxKarat + ";" + MaxRockWeight + ";" + Weight + ";" + ColorBody.Name;
        }

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
