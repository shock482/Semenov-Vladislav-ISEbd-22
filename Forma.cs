using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1sem1
{
    class Forma
    {

        private Apple[] apple;
        private Testo[] testo;
        private Oven[] oven;
        

        public bool ReadyToGo { get { return Check(); } }

        public void Init(int countApple)
        {
            apple = new Apple[countApple];
            testo = new Testo[3];
        }

        public void AddTesto(Testo t)
        {
            for (int i = 0; i < testo.Length; ++i)
            {
                if(testo[i] == null)
                {
                    testo[i] = t;
                    return;
                }
            }
        }


        private bool Check()
        {
            if (testo.Length == 0)
            {
                return false;
            }
            if (apple.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < testo.Length; ++i)
            {
                if(testo[i] == null)
                {
                    return false;
                }
            }
            for (int i = 0; i < apple.Length; ++i)
            {
                if (apple[i] == null)
                {
                    return false;
                }
            }

            return true;
        }

        public void GetHeat()
        {
            if (!Check())
            {
                return;
            }
            if (oven.Length > 0)
            {
                if (oven[0].Temperature < 100)
                {
                    for (int i = 0; i < oven.Length; ++i)
                    {
                        oven[i].Get_Heat();
                    }
                    bool flag = false;
                    switch (oven[0].Temperature)
                    {
                        case 50: flag = true; break;
                        case 100: flag = true; break;
                        case 150: flag = true; break;
                        case 200: flag = true; break;
                    }
                    if (flag)
                    {
                        for (int i = 0; i < testo.Length; ++i)
                        {
                            testo[i].GetHeat();
                        }
                    }
                }
            }
        }

        public bool IsReady()
        {
            for (int i = 0; i < oven.Length; ++i)
            {
                if (oven[i].Temperature < 100)
                {
                    return false;
                }
            }
            return true;
        }

        public Testo[] GetTesto()
        {
            return testo;
        }
    }
}
