using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1sem1
{
    class OvenOn
    {
        private Forma forma;
        public bool State { set; get; }
        public Forma Forma { set { forma = value; } get { return forma; } }

        public void Cook()
        {
            if(State)
            {
                while(!forma.IsReady())
                {
                    forma.GetHeat();
                }
            }
        }
    }
}
