using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1sem1
{
    class Knife
    {
       public void Cut(Apple a)
        {
            if (a.Not_Cut)
            {
                a.Not_Cut = false;
            }
        }
    }
}
