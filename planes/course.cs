﻿using System;
using System.Collections.Generic;
using System.Drawing;
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

        public List<Point> getTrace()
        {
            return course;
        }

        public void nextTurn(double aSpeed, double aRadianDegree)
        {
            Point oldPoint = getLocation();

            int newX = (int)Math.Round(oldPoint.X + Math.Cos(aRadianDegree) * aSpeed);
            int newY = (int)Math.Round(oldPoint.Y + Math.Sin(aRadianDegree) * aSpeed);

            course.Add(new Point(newX, newY));
        }
    }
}
