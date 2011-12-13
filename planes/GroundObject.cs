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
            g.FillRectangle(new SolidBrush(Color.Black), new Rectangle(location.X - 2, location.Y -2, 4, 4));
        }

        public bool IsObjectNear(Point objectLocation) 
        {
            const int selectedQUAD = 10;

            Rectangle region = new Rectangle(location.X - selectedQUAD, location.Y - selectedQUAD, 2 * selectedQUAD, 2 * selectedQUAD);
            
            return region.Contains(objectLocation);
        }
    }
}
