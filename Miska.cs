using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1sem1
{
    class Miska
    {

        private Eggs eggs;
        private Sugar sugar;
        private Muka muka;

        public bool State { get; set; }

        public void AddSugar(Sugar s)
        {
            sugar = s;
        }

        public void AddMuka(Muka m)
        {
            muka = m;
        }

        public void AddEggs(Eggs e1)
        {
            eggs = e1;
        }

        public void Mix(Sugar s, Muka m, Eggs e1)
        {
            if (s.Mix)
            {
                s.Mix = true;
            }
            if (m.Mix)
            {
                m.Mix = true;
            }
            if (e1.Mix)
            {
                e1.Mix = true;
            }
        }
    }
}
