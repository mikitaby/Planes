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
        
        public GameMechanics()
        {
            all_planes = new List<Plane>();
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
            selectedPlane = null;
            foreach (Plane plane in all_planes)
                if (plane.CurrentLocation.X - selectedQUAD < point.X
                    && plane.CurrentLocation.X + selectedQUAD > point.X
                    && plane.CurrentLocation.Y - selectedQUAD < point.Y
                    && plane.CurrentLocation.Y + selectedQUAD > point.Y)
                { 
                    selectedPlane = plane;
                    MessageBox.Show("Selected!");
                }
            //problem: selected last plane in 10x10 quad!
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
            foreach (Plane plane in all_planes)
                if (plane.OnTheFly)
                    plane.Draw(g);                
        }

        public void repaintSelectedObject(Graphics g)
        {
            if (selectedPlane.OnTheFly)
                selectedPlane.selectedDraw(g);            
        }        
    }
}


/*     
               List<Point> all_airfields;                

               all_airfields = new List<Point>();
               all_airfields.Add(new Point(10, 10));
   
               public void checkLanding()
               {
                   foreach (Plane plane in all_planes)
                       if (plane.OnTheFly)
                           foreach (Point airfield in all_airfields)                
                               if (plane.CurrentLocation == airfield)
                                   plane.Landing();
               }

               private void checkCrashes()
               {
                   foreach (Plane plane_one in all_planes)
                       foreach (Plane plane_two in all_planes.Except(plane_one))
                           if (plane_one.CurrentLocation == plane_two.CurrentLocation)
                           {
                               MessageBox.Show("crash!");
                               break;
                           }
               }
*/