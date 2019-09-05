namespace HelloWorldTaishaun
{
    partial class frmHelloWorld
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
            this.lblSignature = new System.Windows.Forms.Label();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.picBasketball = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignature.ForeColor = System.Drawing.Color.Red;
            this.lblSignature.Location = new System.Drawing.Point(215, 155);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(345, 39);
            this.lblSignature.TabIndex = 0;
            this.lblSignature.Text = "By Taishaun Johnson";
            this.lblSignature.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblGreeting.Font = new System.Drawing.Font("Calibri", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGreeting.Location = new System.Drawing.Point(191, 73);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(402, 82);
            this.lblGreeting.TabIndex = 1;
            this.lblGreeting.Text = "Hello, World!";
            // 
            // picBasketball
            // 
            this.picBasketball.Image = global::HelloWorldTaishaun.Properties.Resources.Basketball;
            this.picBasketball.Location = new System.Drawing.Point(275, 220);
            this.picBasketball.Name = "picBasketball";
            this.picBasketball.Size = new System.Drawing.Size(223, 218);
            this.picBasketball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBasketball.TabIndex = 2;
            this.picBasketball.TabStop = false;
            // 
            // frmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBasketball);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.lblSignature);
            this.Name = "frmHelloWorld";
            this.Text = "Hello World by Taishaun";
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.PictureBox picBasketball;
    }
}

