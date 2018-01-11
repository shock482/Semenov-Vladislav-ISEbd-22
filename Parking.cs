using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2sem1
{
    class Parking
    {
        /* ClassArray <IRock> parking;

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
         }*/


        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("CountLevels:" + parkingStages.Count + Environment.NewLine);
                    fs.Write(info, 0, info.Length);
                    foreach (var level in parkingStages)
                    {
                        info = new UTF8Encoding(true).GetBytes("Level" + Environment.NewLine);
                        fs.Write(info, 0, info.Length);
                        for (int i = 0; i < countPlaces; i++)
                        {
                            var rock = level[i];
                            if(rock != null)
                            { 
                                if(rock.GetType().Name == "Rock")
                                {
                                    info = new UTF8Encoding(true).GetBytes("Rock:");
                                    fs.Write(info, 0, info.Length);
                                }
                                if (rock.GetType().Name == "Diamond")
                                {
                                    info = new UTF8Encoding(true).GetBytes("Diamond:");
                                    fs.Write(info, 0, info.Length);
                                }
                                info = new UTF8Encoding(true).GetBytes(rock.getInfo() + Environment.NewLine);
                                fs.Write(info, 0, info.Length);
                            }
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if(!File.Exists(filename))
            {
                return false;
            }
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                string s = "";
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (bs.Read(b, 0, b.Length) > 0)
                    {
                        s += temp.GetString(b);
                    }
                }
                s = s.Replace("\r", "");
                var strs = s.Split('\n');
                if (strs[0].Contains("CountLevels"))
                {
                    int count = Convert.ToInt32(strs[0].Split(':')[1]);
                    if (parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<ClassArray<IRock>>(count);
                }
                else
                {
                    return false;
                }
                int counter = -1;
                for (int i = 1; i < strs.Length; ++i)
                {
                    if(strs[i] == "Level")
                    {
                        counter++;
                        parkingStages.Add(new ClassArray<IRock>(countPlaces, null));
                    }
                    else if (strs[i].Split(':')[0] == "Rock")
                    {
                        IRock rock = new Rock(strs[i].Split(':')[1]);
                        int number = parkingStages[counter] + rock;
                        if (number == -1)
                        {
                            return false;
                        }
                    }
                    else if (strs[i].Split(':')[0] == "Diamond")
                    {
                        IRock rock = new Diamond(strs[i].Split(':')[1]);
                        int number = parkingStages[counter] + rock;
                        if (number == -1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

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
