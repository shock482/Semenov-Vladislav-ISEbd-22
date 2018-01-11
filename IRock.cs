using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2sem1
{
    interface IRock
    {

        void treatmentRock(Graphics g);

        void drawRock(Graphics g);

        void setPosition(int x, int y);

        void weightDiamond(int weightD);

        int getDiamond();

    }
}
