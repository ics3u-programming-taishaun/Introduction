/*
 * Created by: Taishuan Johnson
 * Created on: 11.Sept,2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - Perimeter,Area & Volume
 * This program calculates the perimeter of rectangle, area of a cicle and the volume of a sphere. 
 * It displays the answers in labels when the respective button when clicked.
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

namespace PerAreaVolTaishaun
{
    public partial class FrmPerAreaVol : Form
    {
        public FrmPerAreaVol()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtmQPerimeter_Click(object sender, EventArgs e)
        {
            //Display answer to the perimeter question, when the button is clicked.
            lblAnswer1.Text = Convert.ToString(5 + Math.Pow(2, 3));
        }

        private void BtmQArea_Click(object sender, EventArgs e)
        {
            //Display answer to the area question, when the button is clicked.
            lblAnswer2.Text = Convert.ToString(Math.PI * Math.Pow(7, 2));
        }

        private void BtmQVolume_Click(object sender, EventArgs e)
        {
            // Display answer to the volume question, when the button is clicked. 
            lblAnswer3.Text = Convert.ToString((double)4 /(double)3 * Math.PI * Math.Pow(4, 3));
        }
    }
}
