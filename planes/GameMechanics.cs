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
        private List<Plane> all_planes;
        private Plane selectedPlane;
        private const int selectedQUAD = 10;

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
                {
                    g.FillRectangle(new SolidBrush(Color.Blue), new Rectangle(plane.CurrentLocation.X, plane.CurrentLocation.Y, 4, 4));
                    //g.DrawLine(); - direction
                }
        }

        public void repaintSelectedObject(Graphics g)
        {
            if (selectedPlane.OnTheFly)
            {
                Point p1 = new Point(selectedPlane.CurrentLocation.X - selectedQUAD, selectedPlane.CurrentLocation.Y - selectedQUAD);
                Point p2 = new Point(selectedPlane.CurrentLocation.X - selectedQUAD, selectedPlane.CurrentLocation.Y + selectedQUAD);
                Point p3 = new Point(selectedPlane.CurrentLocation.X + selectedQUAD, selectedPlane.CurrentLocation.Y + selectedQUAD);
                Point p4 = new Point(selectedPlane.CurrentLocation.X + selectedQUAD, selectedPlane.CurrentLocation.Y - selectedQUAD);
                
                Point[] points = new Point[5] { p1, p2, p3, p4, p1 };
                
                g.DrawLines(new Pen(new SolidBrush(Color.Red)),points);
                
                //g.DrawLine(); - direction
            }
        }        
    }
}
