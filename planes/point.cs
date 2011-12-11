using System;
using System.Windows.Forms;

namespace planes
{
    public class Point
    {
        private int x;
        private int y;

        public Point(double aX, double aY)
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
            return obj is Point && this == (Point)obj;
        }

        public override int GetHashCode()
        {
            return x.GetHashCode() ^ y.GetHashCode();
        }

        public static bool operator ==(Point x, Point y)
        {         
            return x.x == y.x && x.y == y.y;            
        }

        public static bool operator !=(Point x, Point y)
        {
            return !(x == y);
        }
    }
}
