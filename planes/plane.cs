using System;
using System.Drawing;
using System.Windows.Forms;

namespace planes
{
    class Plane
    {
        double speed;
        double degree;
        bool onTheFly;
        string name;
        Course course;

        public string Name 
        {
            get {return this.name;}
        }

        public bool OnTheFly
        {
            get {return this.onTheFly;}
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
                if ((value >= 0) && (value < 360))
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
        
        public Point CurrentLocation
        {
            get {return this.course.getLocation();}
        }

        public void nextTurn() 
        {
            this.course.nextTurn(speed, degree);
        }        

        public Plane()
        {
            this.onTheFly = true;
            this.speed = RandomsValues.getRandomSpeed();
            this.degree = RandomsValues.getRandomDegree();
            this.name = RandomsValues.getRandomName();
            this.course = new Course(new Point(RandomsValues.getRandomStartCoordinate(), RandomsValues.getRandomStartCoordinate()));
        }

        public void Draw(Graphics g) 
        {
            foreach(Point passedPoint in course.getTrace())
                g.FillRectangle(new SolidBrush(Color.Green), passedPoint.X - 1, passedPoint.Y - 1, 2, 2);
            
            g.FillRectangle(new SolidBrush(Color.Blue), CurrentLocation.X - 2, CurrentLocation.Y - 2, 4, 4);            
        }

        public void selectedDraw(Graphics g)
        {
            const int selectedQUAD = 10;
            g.DrawEllipse(new Pen(new SolidBrush(Color.Red)), CurrentLocation.X - selectedQUAD, CurrentLocation.Y - selectedQUAD, 2*selectedQUAD, 2*selectedQUAD);
        }
    }
}