using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace planes
{
    public partial class GUI : Form
    {
        IGameMechanics gameMechanics;
        
        public IGameMechanics GameMechanics
        {
            set {gameMechanics = value;}
        }
        
        public GUI()
        {
            InitializeComponent();
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
            gameMechanics.changePlaneParams("", 1, 1);
        }

        private void pbFlyField_MouseClick(object sender, MouseEventArgs e)
        {
            System.Drawing.Point p = e.Location;           
        }        
    }
}
