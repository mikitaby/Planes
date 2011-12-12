﻿using System;
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
        private IGameMechanics gameMechanics;
        
        const decimal SPEED = 1;
        const decimal DEGREE = 1;

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
                gameMechanics.changeSelectedObjectParams(SPEED, DEGREE);
        }

        private void pbFlyField_MouseClick(object sender, MouseEventArgs e)
        {
            gameMechanics.selectObject(e.Location);
            
            if (gameMechanics.isObjectSelected())
                using (Graphics graphics = pbFlyField.CreateGraphics())
                    gameMechanics.repaintSelectedObject(graphics);
        }        
    }
}
