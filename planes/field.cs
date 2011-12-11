using System.Collections.Generic;
using System.Drawing;
using System;

namespace planes
{
    class Field : IDrawObject, IPlaneCollection
    {
        public List<Plane> all_planes;
        List<Point> all_airfields;

        public void Draw(Graphics g)
        {
            foreach (Plane plane in all_planes)
                if (plane.OnTheFly)
                { 
                    g.FillRectangle(new SolidBrush(Color.Blue), new Rectangle(plane.CurrentLocation.X, plane.CurrentLocation.Y, 2, 2)); 
                    //g.DrawLine(); - direction
                }
        }

        public Plane getPlaneByName(string aName) 
        {
            foreach (Plane plane in all_planes)
                if (plane.Name == aName)
                    return plane;
            throw new Exception("Plane: '" + aName + "' not exeists!");
        }

        public Field() 
        {
            all_planes = new List<Plane>();
            all_airfields = new List<Point>();
            
            all_airfields.Add(new Point(10, 10));
        }
        
        public void addPlane()
        {            
            all_planes.Add(new Plane(RandomsValues.getRandomSpeed(),
                                     RandomsValues.getRandomDegree(),
                                     new Point(RandomsValues.getRandomStartCoordinate(), RandomsValues.getRandomStartCoordinate()),
                                     RandomsValues.getRandomName()));
        }

        public void nextTurn() 
        {
            foreach (Plane plane in all_planes)
                plane.nextTurn();            
        }
  
        public void checkLanding()
        {
            foreach (Plane plane in all_planes)
                if (plane.OnTheFly)
                    foreach (Point airfield in all_airfields)                
                        if (plane.CurrentLocation == airfield)
                            plane.Landing();
        }       
    }
}


/*
                            //airfield.debugShow();
                            //plane.CurrentLocation.debugShow();
         * 
         * private void checkCrashes() 
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