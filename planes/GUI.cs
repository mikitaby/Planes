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

        private void btnTurn_Click(object sender, EventArgs e)
        {
            gameMechanics.nextTurn();

            using (Graphics graphics = pbFlyField.CreateGraphics()) 
                gameMechanics.drawObjects(graphics);
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
    }
}
