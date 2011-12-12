using System.Drawing;

namespace planes
{
    public interface IGameMechanics
    {   
        void addPlane();
        void drawObjects(Graphics g);
        void nextTurn();
        bool isObjectSelected();
        void selectObject(Point point);
        void changeSelectedObjectParams(decimal aSpeed, decimal aDegree);
        void repaintSelectedObject(Graphics g);
    }
}
