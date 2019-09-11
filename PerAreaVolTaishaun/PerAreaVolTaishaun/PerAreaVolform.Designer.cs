namespace PerAreaVolTaishaun
{
    partial class FrmPerAreaVol
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
            this.btmQPerimeter = new System.Windows.Forms.Button();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.btmQArea = new System.Windows.Forms.Button();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.btmQVolume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btmQPerimeter
            // 
            this.btmQPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmQPerimeter.Location = new System.Drawing.Point(36, 12);
            this.btmQPerimeter.Name = "btmQPerimeter";
            this.btmQPerimeter.Size = new System.Drawing.Size(287, 133);
            this.btmQPerimeter.TabIndex = 0;
            this.btmQPerimeter.Text = "Calculate the perimeter of a rectangle with a length of 8cm and width of 5cm\r\n";
            this.btmQPerimeter.UseVisualStyleBackColor = true;
            this.btmQPerimeter.Click += new System.EventHandler(this.BtmQPerimeter_Click);
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer1.Location = new System.Drawing.Point(526, 70);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(48, 26);
            this.lblAnswer1.TabIndex = 1;
            this.lblAnswer1.Text = "???";
            this.lblAnswer1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btmQArea
            // 
            this.btmQArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmQArea.Location = new System.Drawing.Point(36, 151);
            this.btmQArea.Name = "btmQArea";
            this.btmQArea.Size = new System.Drawing.Size(287, 143);
            this.btmQArea.TabIndex = 2;
            this.btmQArea.Text = "Calculate the area of a circle with radius 7cm \r\n";
            this.btmQArea.UseVisualStyleBackColor = true;
            this.btmQArea.Click += new System.EventHandler(this.BtmQArea_Click);
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.AutoSize = true;
            this.lblAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer3.Location = new System.Drawing.Point(526, 355);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(48, 26);
            this.lblAnswer3.TabIndex = 3;
            this.lblAnswer3.Text = "???";
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer2.Location = new System.Drawing.Point(526, 217);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(48, 26);
            this.lblAnswer2.TabIndex = 4;
            this.lblAnswer2.Text = "???";
            // 
            // btmQVolume
            // 
            this.btmQVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmQVolume.Location = new System.Drawing.Point(36, 300);
            this.btmQVolume.Name = "btmQVolume";
            this.btmQVolume.Size = new System.Drawing.Size(287, 124);
            this.btmQVolume.TabIndex = 5;
            this.btmQVolume.Text = "Calculate the volume of a sphere with radius 4cm";
            this.btmQVolume.UseVisualStyleBackColor = true;
            this.btmQVolume.Click += new System.EventHandler(this.BtmQVolume_Click);
            // 
            // FrmPerAreaVol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btmQVolume);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.lblAnswer3);
            this.Controls.Add(this.btmQArea);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.btmQPerimeter);
            this.Name = "FrmPerAreaVol";
            this.Text = "Per Area Vol by Taishaun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmQPerimeter;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Button btmQArea;
        private System.Windows.Forms.Label lblAnswer3;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.Button btmQVolume;
    }
}

