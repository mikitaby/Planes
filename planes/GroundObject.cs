using System.Drawing;

namespace planes
{
    public interface IGroundObject
    {
        void Draw(Graphics g);
        bool IsObjectNear(Point objectLocation);
    }

    public class GroundObject : IGroundObject
    {
        private Point location;
        
        public GroundObject() 
        {
            int x = RandomsValues.getRandomStartCoordinate();
            int y = RandomsValues.getRandomStartCoordinate();
            location = new Point(x, y);
        }
        
        public void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Black), new Rectangle(location, new Size(4, 4)));
        }

        public bool IsObjectNear(Point objectLocation) 
        {
            const int selectedQUAD = 10;
            return objectLocation.X - selectedQUAD < location.X
                    && objectLocation.X + selectedQUAD > location.X
                    && objectLocation.Y - selectedQUAD < location.Y
                    && objectLocation.Y + selectedQUAD > location.Y;
        }
    }
}
