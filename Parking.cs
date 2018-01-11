﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2sem1
{
    class Parking
    {
        ClassArray <IRock> parking;

        int CountPlaces = 20;
        int placeSizeWidth = 210;
        int placeSizeHeight = 80;

        public Parking()
        {
            parking = new ClassArray<IRock>(CountPlaces, null);
        }

        public int PutRockInParking(IRock rock)
        {
            return parking + rock;
        }

        public IRock GetRockInParking(int ticket)
        {
            return parking - ticket;
        }

        public void Draw(Graphics g, int width, int height)
        {
            DrawMarking(g);
            for (int i = 0; i < CountPlaces; i++)
            {
                var rock = parking.getObject(i);
                if (rock != null)
                {
                    rock.setPosition(5 + i / 5 * placeSizeWidth + 23, i % 5 * placeSizeHeight +5);
                    rock.drawRock(g);
                }
            }
        }


        public void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Bisque, 3);
            g.DrawRectangle(pen, 0, 0, (CountPlaces / 5) * placeSizeHeight, 480);
            for (int i = 0; i < CountPlaces / 5; i++)
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
