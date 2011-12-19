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
        void changeSelectedObjectParams(Point pointTo);
        void repaintSelectedObject(Graphics g);
        void checkLanding();
        void checkCrashes();        
    }
}
