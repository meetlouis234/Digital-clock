using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();
            YellowButton.FlatStyle = FlatStyle.Flat;
            WhiteButton.FlatStyle = FlatStyle.Flat;
            GreenButton.FlatStyle = FlatStyle.Flat;
            SkbButton.FlatStyle = FlatStyle.Flat;
            redButton.FlatStyle = FlatStyle.Flat;
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToString("hh: mm: ss");
        }

        private void Digital_Clock(object sender, EventArgs e)
        {
            Clock.Start();

        }

        private void SkbButton_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.SkyBlue;
        }

        private void GreenButton_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.Green;
        }

                private void WhiteButton_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.White;
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.Red;
        }

        private void YellowButton_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.Yellow;
        }
    }
}
