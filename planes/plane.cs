using System;
using System.Windows.Forms;

namespace planes
{
    class Plane
    {
        double speed;
        double degree;
        bool onTheFly;
        string name;

        public string Name 
        {
            get
            {
                return this.name;
            }
        }

        public bool OnTheFly
        {
            get 
            {
                return this.onTheFly;
            }
        }

        public void Landing()
        {
            onTheFly = false;
            MessageBox.Show("sucsessfully landing");
        }

        public double Degree
        {
            set
            {
                if ((value >= 0) && (value < 2*Math.PI))
                {
                    degree = value;
                    MessageBox.Show("Plane " + name + " new degree: " + degree.ToString());
                }
                else
                    throw new Exception("incorrect degree value" + value);
            }
        }

        public double Speed
        {
            set
            {
                
                if (value > 0)
                {
                    speed = value;
                    MessageBox.Show("Plane " + name + " new speed: " + speed.ToString());
                }
                else
                    throw new Exception("incorrect speed value" + value);
            }
        }

        Course course;
        
        public MyPoint CurrentLocation
        {
            get
            {
                return this.course.getLocation();
            }
        }

        public void nextTurn() 
        {
            this.course.nextTurn(speed, degree);
        }        

        public Plane(double aSpeed, double aDegree, MyPoint aStartPoint, string aName)
        {
            this.onTheFly = true;
            this.speed = aSpeed;
            this.degree = aDegree;
            this.name = aName;
            this.course = new Course(aStartPoint);
        }      
    }
}