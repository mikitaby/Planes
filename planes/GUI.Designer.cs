namespace planes
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbFlyField = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnTurn = new System.Windows.Forms.Button();
            this.btnChangePlaneParams = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlyField)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFlyField
            // 
            this.pbFlyField.Location = new System.Drawing.Point(12, 12);
            this.pbFlyField.Name = "pbFlyField";
            this.pbFlyField.Size = new System.Drawing.Size(903, 487);
            this.pbFlyField.TabIndex = 0;
            this.pbFlyField.TabStop = false;
            this.pbFlyField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbFlyField_MouseClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(193, 505);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnTurn
            // 
            this.btnTurn.Location = new System.Drawing.Point(274, 505);
            this.btnTurn.Name = "btnTurn";
            this.btnTurn.Size = new System.Drawing.Size(75, 23);
            this.btnTurn.TabIndex = 2;
            this.btnTurn.Text = "Turn";
            this.btnTurn.UseVisualStyleBackColor = true;
            this.btnTurn.Click += new System.EventHandler(this.btnTurn_Click);
            // 
            // btnChangePlaneParams
            // 
            this.btnChangePlaneParams.Location = new System.Drawing.Point(529, 505);
            this.btnChangePlaneParams.Name = "btnChangePlaneParams";
            this.btnChangePlaneParams.Size = new System.Drawing.Size(155, 23);
            this.btnChangePlaneParams.TabIndex = 3;
            this.btnChangePlaneParams.Text = "changePlaneParams";
            this.btnChangePlaneParams.UseVisualStyleBackColor = true;
            this.btnChangePlaneParams.Click += new System.EventHandler(this.btnChangePlaneParams_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 540);
            this.Controls.Add(this.btnChangePlaneParams);
            this.Controls.Add(this.btnTurn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pbFlyField);
            this.Name = "GUI";
            this.Text = "GUI";
            ((System.ComponentModel.ISupportInitialize)(this.pbFlyField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFlyField;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnTurn;
        private System.Windows.Forms.Button btnChangePlaneParams;
    }
}