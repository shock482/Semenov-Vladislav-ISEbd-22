using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1sem1
{
    class Testo
    {

        private int has_ready = 0;
        public bool has_korka { set; get; }
        public int Has_ready { get { return has_ready; } }

        public void GetHeat()
        {
            if(has_ready < 10)
            {
                has_ready++;
            }
        }
    }
}
