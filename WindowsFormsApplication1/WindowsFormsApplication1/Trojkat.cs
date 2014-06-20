using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Trojkat
    {
        public int poleTrojkat(int a, int h)
        {
            if (a < 0 || h < 0)
            {
                return -1;
            }
            else
            {
                return (a * h) / 2;
            }
        }
    }
}
