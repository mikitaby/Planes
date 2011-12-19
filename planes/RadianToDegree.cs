using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace planes
{
    public static class RadianToDegree
    {
        public static int ToDegree(double radian) 
        {
            return (int)Math.Round((radian % (2*Math.PI)) * 180 / Math.PI, 0);            
        }
    }
}
