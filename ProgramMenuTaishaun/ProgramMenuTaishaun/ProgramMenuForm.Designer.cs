namespace ProgramMenuTaishaun
{
    partial class frmProgramMenu
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
            this.lblSoccerTeam = new System.Windows.Forms.Label();
            this.lblKevinDeBruyne = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mniProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSoccerTeam
            // 
            this.lblSoccerTeam.AutoSize = true;
            this.lblSoccerTeam.Font = new System.Drawing.Font("Lucida Sans", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoccerTeam.Location = new System.Drawing.Point(84, 57);
            this.lblSoccerTeam.Name = "lblSoccerTeam";
            this.lblSoccerTeam.Size = new System.Drawing.Size(610, 78);
            this.lblSoccerTeam.TabIndex = 0;
            this.lblSoccerTeam.Text = "Manchester City ";
            // 
            // lblKevinDeBruyne
            // 
            this.lblKevinDeBruyne.AutoSize = true;
            this.lblKevinDeBruyne.BackColor = System.Drawing.Color.Transparent;
            this.lblKevinDeBruyne.Font = new System.Drawing.Font("CommercialScript BT", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKevinDeBruyne.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblKevinDeBruyne.Location = new System.Drawing.Point(145, 165);
            this.lblKevinDeBruyne.Name = "lblKevinDeBruyne";
            this.lblKevinDeBruyne.Size = new System.Drawing.Size(494, 62);
            this.lblKevinDeBruyne.TabIndex = 1;
            this.lblKevinDeBruyne.Text = "Kevin De Bruyne #17";
            this.lblKevinDeBruyne.Click += new System.EventHandler(this.LblKevinDeBruyne_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProgramMenuTaishaun.Properties.Resources.Kevin;
            this.pictureBox1.Location = new System.Drawing.Point(265, 251);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniProgram});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(800, 24);
            this.mnuMenu.TabIndex = 3;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mniProgram
            // 
            this.mniProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniProgram.Name = "mniProgram";
            this.mniProgram.Size = new System.Drawing.Size(65, 20);
            this.mniProgram.Text = "Program";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(180, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.MniExit_Click);
            // 
            // frmProgramMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblKevinDeBruyne);
            this.Controls.Add(this.lblSoccerTeam);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "frmProgramMenu";
            this.Text = "Program Menu by Taishaun";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoccerTeam;
        private System.Windows.Forms.Label lblKevinDeBruyne;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mniProgram;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}

