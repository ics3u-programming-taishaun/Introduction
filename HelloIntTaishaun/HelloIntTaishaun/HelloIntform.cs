/*
 * Created by: Taishaun Johnson
 * Created on: Sept 10, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - Hello World International
 * This program displays the greeting hello world! in different languages
 * depending on which radio button is clicked.
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

namespace HelloIntTaishaun
{
    public partial class frmHelloInt : Form
    {
        public frmHelloInt()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RadSpanish_CheckedChanged(object sender, EventArgs e)
        {
            //Change the greeting to spanish
            this.lblGreeting.Text = "Hola Mundo";
        }

        private void RadFrench_CheckedChanged(object sender, EventArgs e)
        {
            //Change the greeting to french
            this.lblGreeting.Text = "Bonjour le monde";
        }

        private void RadEnglish_CheckedChanged(object sender, EventArgs e)
        {
            //Change the greeting to English
            this.lblGreeting.Text = "Hello, World!";
        }

        private void RadGerman_CheckedChanged(object sender, EventArgs e)
        {
            //Change the greeting to Dutch 
            this.lblGreeting.Text = "Hallo Welt";
        }
    }
}
