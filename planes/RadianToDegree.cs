using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace planes
{
    public static class RadianToDegree
    {
        public static int ToDegree(double normalisedRadian) //[0:2*pi)
        {
            return (int)(normalisedRadian * 180 / Math.PI);
        }
    }
}
