using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace planes
{
    public class GameMechanics : IGameMechanics
    {
        public void addPlane()
        {
            MessageBox.Show("Add Plane");
        }

        public void drawObjects(Graphics g)
        {
            MessageBox.Show("Draw objects");
        }

        public void nextTurn()
        {
            MessageBox.Show("Next Turn");
        }

        public bool isObjectSelected() 
        {
            MessageBox.Show("Is object selected");
            return true;            
        }

        public void selectObject(Point point) 
        {
            MessageBox.Show("Try to select object");
        }

        public void changeSelectedObjectParams(decimal aSpeed, decimal aDegree)
        {
            MessageBox.Show("Change object params");
        }

        public void repaintSelectedObject(Graphics g)
        {
            MessageBox.Show("RepaintSelectedObject");
        }        
    }
}
