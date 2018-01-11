using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2sem1
{
    class Parking
    {
        List<ClassArray<IRock>> parkingStages;
        int countPlaces = 20;
        int placeSizeWidth = 210;
        int placeSizeHeight = 80;
        int currentLevel;

        public int getCurrentLevel { get { return currentLevel; } }

        public Parking(int countStages) {
            parkingStages = new List<ClassArray<IRock>>(countStages);
            for (int i = 0; i < countStages; i++)
            {
                parkingStages.Add(new ClassArray<IRock>(countPlaces, null));
            }
        }

        public void LevelUp()
        {
            if (currentLevel + 1 < parkingStages.Count)
            {
                currentLevel++;
            }
        }

        public void LevelDown()
        {
            if (currentLevel > 0)
            {
                currentLevel--;
            }
        }

        public int PutRockInParking(IRock rock)
        {
            return parkingStages[currentLevel] + rock;
        }

        public IRock GetRockInParking(int ticket)
        {
            return parkingStages[currentLevel] - ticket;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < countPlaces; i++)
            {
                var rock = parkingStages[currentLevel][i];
                if (rock != null)
                {
                    rock.setPosition(5 + i / 5 * placeSizeWidth + 23, i % 5 * placeSizeHeight + 5);
                    rock.drawRock(g);
                }
            }
        }

        public void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Bisque, 3);
            g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placeSizeHeight, 480);
            for (int i = 0; i < countPlaces / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + 110, j * placeSizeHeight);

                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 400);

            }
            g.DrawLine(pen, 110, 0, 110, 500);
            g.DrawLine(pen, 530, 0, 530, 500);
        }
    }
}
