using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1sem1
{
    class Oven
    {
        private int temperature = 0;
        public int Temperature { get { return temperature; } }

        public void Get_Heat()
        {
            if (temperature < 100)
            {
                temperature++;
            }       
        }
    }
}
