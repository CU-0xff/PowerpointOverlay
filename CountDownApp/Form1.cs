using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDownApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void SetConfig(Configuration myConfig)
        {
            config = myConfig;
        }

        private void onLoad(object sender, EventArgs e)
        {
            this.Location = this.config.Location;

            this.label1.Font = new System.Drawing.Font(this.config.FontName, this.config.FontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = this.config.FontColor;

        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            if(config.IsLoaded == false ) { timer1.Enabled = true; return; }

            DateTime nextProgramStart = config.program.Keys.Where(start => start >= DateTime.Now).Min();

            string newDisplayText = "Next: " + config.program[nextProgramStart].Text + " "  + System.DateTime.Now.ToLongTimeString();

            Size newDisplayTextSize = TextRenderer.MeasureText(newDisplayText, this.label1.Font);
            newDisplayTextSize.Height += 20; newDisplayTextSize.Width += 20;

            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;

            Point newLocation = this.Location;
            
            newLocation.X = (workingRectangle.Width - newDisplayTextSize.Width) / 2;

            this.Location = newLocation;

            this.Size = newDisplayTextSize;
            this.label1.Text = newDisplayText;

            timer1.Enabled = true;

        }

        private void OnShown(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }
    }
}
