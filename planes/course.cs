using System;
using System.Collections.Generic;
using System.Linq;

namespace planes
{
    class Course
    {
        private List<Point> course;

        public Course(Point aStartPoint) 
        {
            course = new List<Point>();
            course.Add(aStartPoint);
        }

        public Point getLocation()
        {
            return course.ElementAt(course.Count - 1);
        }

        public void nextTurn(double aSpeed, double aDegree)
        {
            Point oldPoint = getLocation();
                       
            double newX = oldPoint.X + Math.Cos(aDegree) * aSpeed;
            double newY = oldPoint.Y + Math.Sin(aDegree) * aSpeed;
                        
            course.Add(new Point(newX, newY));            
        }
    }
}
