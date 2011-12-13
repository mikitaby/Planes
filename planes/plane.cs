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
            {
                g.FillRectangle(new SolidBrush(Color.Green), new Rectangle(passedPoint, new Size(2, 2)));
            }
            
            Point locationPoint = new Point(CurrentLocation.X, CurrentLocation.Y);
            g.FillRectangle(new SolidBrush(Color.Blue), new Rectangle(locationPoint, new Size(4, 4)));
        }

        public void selectedDraw(Graphics g)
        {
            const int selectedQUAD = 10;

            int x = CurrentLocation.X;
            int y = CurrentLocation.Y;

            Point p1 = new Point(x - selectedQUAD, y - selectedQUAD);
            Point p2 = new Point(x - selectedQUAD, y + selectedQUAD);
            Point p3 = new Point(x + selectedQUAD, y + selectedQUAD);
            Point p4 = new Point(x + selectedQUAD, y - selectedQUAD);

            Point[] points = new Point[5] { p1, p2, p3, p4, p1 };

            g.DrawLines(new Pen(new SolidBrush(Color.Red)), points);
        }
    }
}