using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace planes
{
    public class GameMechanics : IGameMechanics
    {
        
        const int selectedQUAD = 10;

        private List<Plane> all_planes;
        private Plane selectedPlane;
        IGroundObject airPort;

        public GameMechanics()
        {
            all_planes = new List<Plane>();
            airPort = new GroundObject(); 

            selectedPlane = null;
        }        
        
        public void addPlane()
        {
            all_planes.Add(new Plane());
        }

        public void nextTurn()
        {
            foreach (Plane plane in all_planes)
                plane.nextTurn();
        }
        
        public void selectObject(Point point)
        {
            Rectangle region = new Rectangle(point.X - selectedQUAD, point.Y - selectedQUAD, 2 * selectedQUAD, 2 * selectedQUAD);
            
            selectedPlane = null;
            foreach (Plane plane in all_planes)
                if (region.Contains(plane.CurrentLocation))
                { 
                    selectedPlane = plane;
                    MessageBox.Show("Selected!");
                }
            //problem: selected last plane in selectedQUAD x selectedQUAD quad!
        }

        public bool isObjectSelected() 
        {            
            return (selectedPlane != null);
        }
        
        public void changeSelectedObjectParams(double aSpeed, double aDegree)
        {
            selectedPlane.Speed = aSpeed;
            selectedPlane.Degree = aDegree;
        }

        public void drawObjects(Graphics g)
        {            
            g.Clear(Color.Gray);
            foreach (Plane plane in all_planes)
                if (plane.OnTheFly)
                    plane.Draw(g);
            airPort.Draw(g);    //может быть стоит рисовать только один раз?
        }

        public void repaintSelectedObject(Graphics g)
        {
            if (selectedPlane.OnTheFly)
                selectedPlane.selectedDraw(g);            
        }

        public void checkLanding()
        {
            foreach (Plane plane in all_planes)
                if (plane.OnTheFly && airPort.IsObjectNear(plane.CurrentLocation))
                    plane.Landing();
        }

        public void checkCrashes()
        {            
            foreach (Plane plane_one in all_planes)
                foreach (Plane plane_two in all_planes)
                    if ((plane_one != plane_two) && (plane_one.CurrentLocation == plane_two.CurrentLocation))
                    {
                        MessageBox.Show("crash!");
                        break;
                    }            
        }
    }
}