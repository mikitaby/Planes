using System;
using System.Collections.Generic;
using System.Linq;

namespace planes
{
    class Course
    {
        private List<MyPoint> course;

        public Course(MyPoint aStartPoint) 
        {
            course = new List<MyPoint>();
            course.Add(aStartPoint);
        }

        public MyPoint getLocation()
        {
            return course.ElementAt(course.Count - 1);
        }

        public void nextTurn(double aSpeed, double aDegree)
        {
            MyPoint oldPoint = getLocation();
                       
            double newX = oldPoint.X + Math.Cos(aDegree) * aSpeed;
            double newY = oldPoint.Y + Math.Sin(aDegree) * aSpeed;
                        
            course.Add(new MyPoint(newX, newY));            
        }
    }
}
