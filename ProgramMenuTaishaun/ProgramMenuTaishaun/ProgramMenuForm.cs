/*
 * Created by: Taishaun Johnson
 * Created on: Sept. 6, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #4 - Hello World with Menu
 * This program displays my Favourite soccer team and player but with an exit menu
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramMenuTaishaun
{
    public partial class frmProgramMenu : Form
    {
        public frmProgramMenu()
        {
            InitializeComponent();
        }

        private void LblKevinDeBruyne_Click(object sender, EventArgs e)
        {

        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            // this will close the program 
            this.Close();
        }
    }
}
