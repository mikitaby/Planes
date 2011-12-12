using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace planes
{
    public interface IGameMechanics
    {
        void addPlane();
        void drawObjects(Graphics g);
        void nextTurn();
        void changePlaneParams(Point point, decimal aSpeed, decimal aDegree);
    }
}
