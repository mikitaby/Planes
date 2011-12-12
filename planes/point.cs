using System;
using System.Windows.Forms;

namespace planes
{
    public class MyPoint
    {
        private int x;
        private int y;

        public MyPoint(double aX, double aY)
        {
            this.x = (int)Math.Round(aX);
            this.y = (int)Math.Round(aY);
        }

        public override string ToString() 
        {
            return "x: " + x + " y: " + y;
        }
        
        public int X
        {
            get
            {
                return this.x;
            }
        }
        
        public int Y
        {
            get
            {
                return this.y;
            }
        }

        public override bool Equals(Object obj)
        {
            return obj is MyPoint && this == (MyPoint)obj;
        }

        public override int GetHashCode()
        {
            return x.GetHashCode() ^ y.GetHashCode();
        }

        public static bool operator ==(MyPoint x, MyPoint y)
        {         
            return x.x == y.x && x.y == y.y;            
        }

        public static bool operator !=(MyPoint x, MyPoint y)
        {
            return !(x == y);
        }
    }
}
