using System;
using System.Drawing;
using System.Windows.Forms;

namespace planes
{
    public partial class GUI : Form
    {
        private IGameMechanics gameMechanics;

        public GUI()
        {
            InitializeComponent();
        }

        public IGameMechanics GameMechanics
        {
            set {gameMechanics = value;}
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            gameMechanics.addPlane();
        }
        
        private void btnChangePlaneParams_Click(object sender, EventArgs e)
        {            
            if (gameMechanics.isObjectSelected())
                gameMechanics.changeSelectedObjectParams(getNewSpeed(), getNewDegree());
        }

        private void pbFlyField_MouseClick(object sender, MouseEventArgs e)
        {
            gameMechanics.selectObject(e.Location);
            
            if (gameMechanics.isObjectSelected())
                using (Graphics graphics = pbFlyField.CreateGraphics())
                    gameMechanics.repaintSelectedObject(graphics);
        }

        double getNewSpeed() 
        {
            return RandomsValues.getRandomSpeed();
        }
        
        double getNewDegree() 
        {
            return RandomsValues.getRandomDegree();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Graphics graphics = pbFlyField.CreateGraphics())
            {
                MessageBox.Show(graphics.DpiX.ToString() + ":" + graphics.DpiY.ToString());
                graphics.FillRectangle(new SolidBrush(Color.Blue), new Rectangle(96, 96, 10, 10));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gameMechanics.nextTurn();

            gameMechanics.checkLanding();
            gameMechanics.checkCrashes();

            using (Graphics graphics = pbFlyField.CreateGraphics())
                gameMechanics.drawObjects(graphics);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
