using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketManagmentFINAL
{
    public partial class Animaton : Form
    {
        public Animaton()
        {
            InitializeComponent();
        }
        // Start point for the progress bar
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //increase the progress bar by 1 and set the progress bar = that value
            startpoint += 1;
            myprogressbar.Value = startpoint;
            if(myprogressbar.Value == 100)
            {
                //information when the progress bar reaches the end to open the new form
                myprogressbar.Value = 0;
                timer1.Stop();
                Form1 log = new Form1();
                this.Hide();
                log.Show();


            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
