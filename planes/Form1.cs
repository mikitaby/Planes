using System;
using System.Windows.Forms;
using System.Drawing;

namespace planes
{
    public partial class Form1 : Form
    {
        Field flyField;
        IGameMechanics gm;

        public Form1()
        {
            InitializeComponent();
            flyField = new Field();

            GameMechanics gameMechanics = new GameMechanics();
            gm = gameMechanics;
        }

        private void addPlane(IPlaneCollection planeCollection)
        {
            planeCollection.addPlane();
        }

        private void Turn(IPlaneCollection planeCollection, IDrawObject drawObject)
        {
            ChangeAirPlanesParams();

            planeCollection.nextTurn();
            planeCollection.checkLanding();

            Graphics g = pictureBox1.CreateGraphics();
            gm.drawObjects(g);
            drawObject.Draw(g); //delete
            g.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turn(flyField, flyField);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Turn(flyField, flyField);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addPlane(flyField);
            gm.addPlane();
        }

        private void ChangeAirPlanesParams()
        {
            foreach (Plane plane in flyField.all_planes)
            {
                if (1 == (new Random()).Next(2)) //changeDegree
                    plane.Degree = RandomsValues.getRandomDegree();

                if (1 == (new Random()).Next(2)) //changeSpeed
                    plane.Speed = RandomsValues.getRandomSpeed();
            }
        }
    }

    interface IFlyParamsChanger
    {
        void ChangeSpeed(double aSpeed);
        void ChangeDegree(double aDegree);        
    }

    interface IPlaneCollection
    {
        void addPlane();
        void nextTurn();
        void checkLanding();
    }

    public static class RandomsValues 
    {
        public static double getRandomSpeed()
        {
            return (new Random()).NextDouble() + (new Random()).Next(5);
        }

        public static double getRandomDegree()
        {
            return (new Random()).NextDouble() + (new Random()).Next(5);
        }

        public static string getRandomName()
        {
            return "Борт " + (new Random()).Next(1000).ToString();
        }

        public static int getRandomStartCoordinate()
        {
            return (new Random()).Next(1000);
        }
    }

    public interface IPoint
    {
     //   public IPoint(double aX, double aY);
        public int X {get;}
        public int Y {get;}
    }

    public interface IGameMechanics
    {
        void addPlane();
        void drawObjects(Graphics g);
        void nextTurn();
        void changePlaneParams(System.Drawing.Point point, decimal aSpeed, decimal aDegree);
    }

    public class GameMechanics : IGameMechanics
    {
        public void addPlane()
        {

        }
        public void drawObjects(Graphics g)
        {

        }
        public void nextTurn()
        {

        }

        public void changePlaneParams(System.Drawing.Point point, decimal aSpeed, decimal aDegree)
        {

        }
    }    
}

/*
 private void UnitTestEqualPoints()
        {
            Point p1 = new Point(1, 1);
            Point p2 = new Point(-1, 1);
            Point p3 = new Point(1, 1);

            if (p1 == p3)
                MessageBox.Show("ok");
            if (p3 == p1)
                MessageBox.Show("ok");
            if (p1 == p2)
                MessageBox.Show("bad");
            else
                MessageBox.Show("ok");
        }
 */