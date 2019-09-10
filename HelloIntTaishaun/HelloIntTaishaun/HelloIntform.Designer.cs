namespace HelloIntTaishaun
{
    partial class frmHelloInt
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbGreetings = new System.Windows.Forms.GroupBox();
            this.radGerman = new System.Windows.Forms.RadioButton();
            this.radSpanish = new System.Windows.Forms.RadioButton();
            this.radFrench = new System.Windows.Forms.RadioButton();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.grbGreetings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("CityBlueprint", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblGreeting.ForeColor = System.Drawing.Color.Blue;
            this.lblGreeting.Location = new System.Drawing.Point(200, 55);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(357, 86);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello, World!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // grbGreetings
            // 
            this.grbGreetings.Controls.Add(this.radGerman);
            this.grbGreetings.Controls.Add(this.radSpanish);
            this.grbGreetings.Controls.Add(this.radFrench);
            this.grbGreetings.Controls.Add(this.radEnglish);
            this.grbGreetings.Location = new System.Drawing.Point(134, 255);
            this.grbGreetings.Name = "grbGreetings";
            this.grbGreetings.Size = new System.Drawing.Size(516, 127);
            this.grbGreetings.TabIndex = 2;
            this.grbGreetings.TabStop = false;
            this.grbGreetings.Text = "Language Select";
            // 
            // radGerman
            // 
            this.radGerman.AutoSize = true;
            this.radGerman.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGerman.ForeColor = System.Drawing.Color.Purple;
            this.radGerman.Location = new System.Drawing.Point(379, 64);
            this.radGerman.Name = "radGerman";
            this.radGerman.Size = new System.Drawing.Size(122, 30);
            this.radGerman.TabIndex = 3;
            this.radGerman.TabStop = true;
            this.radGerman.Text = "Deutsche";
            this.radGerman.UseVisualStyleBackColor = true;
            this.radGerman.CheckedChanged += new System.EventHandler(this.RadGerman_CheckedChanged);
            // 
            // radSpanish
            // 
            this.radSpanish.AutoSize = true;
            this.radSpanish.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSpanish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radSpanish.Location = new System.Drawing.Point(264, 64);
            this.radSpanish.Name = "radSpanish";
            this.radSpanish.Size = new System.Drawing.Size(109, 30);
            this.radSpanish.TabIndex = 2;
            this.radSpanish.TabStop = true;
            this.radSpanish.Text = "Español";
            this.radSpanish.UseVisualStyleBackColor = true;
            this.radSpanish.CheckedChanged += new System.EventHandler(this.RadSpanish_CheckedChanged);
            // 
            // radFrench
            // 
            this.radFrench.AutoSize = true;
            this.radFrench.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFrench.ForeColor = System.Drawing.Color.Red;
            this.radFrench.Location = new System.Drawing.Point(135, 64);
            this.radFrench.Name = "radFrench";
            this.radFrench.Size = new System.Drawing.Size(113, 30);
            this.radFrench.TabIndex = 1;
            this.radFrench.TabStop = true;
            this.radFrench.Text = "Français";
            this.radFrench.UseVisualStyleBackColor = true;
            this.radFrench.CheckedChanged += new System.EventHandler(this.RadFrench_CheckedChanged);
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEnglish.ForeColor = System.Drawing.Color.Blue;
            this.radEnglish.Location = new System.Drawing.Point(27, 64);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(102, 30);
            this.radEnglish.TabIndex = 0;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.RadEnglish_CheckedChanged);
            // 
            // frmHelloInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbGreetings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblGreeting);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "frmHelloInt";
            this.Text = "Hello World International by Taishaun";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbGreetings.ResumeLayout(false);
            this.grbGreetings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbGreetings;
        private System.Windows.Forms.RadioButton radEnglish;
        private System.Windows.Forms.RadioButton radFrench;
        private System.Windows.Forms.RadioButton radSpanish;
        private System.Windows.Forms.RadioButton radGerman;
    }
}

