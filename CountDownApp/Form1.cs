using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            ApplyConfig();
        }

        private void onLoad(object sender, EventArgs e)
        {

            ApplyConfig();
        }

        private void ApplyConfig() { 
            this.marqueeTextbox1.Font = new System.Drawing.Font(this.config.FontName, this.config.FontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marqueeTextbox1.Color = this.config.FontColor;
            this.marqueeTextbox1.Speed = this.config.MarqueeSpeed;

            this.Location = this.config.Location;
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            if (config.IsLoaded == false) { timer1.Enabled = true; return; }

            string newDisplayText = System.DateTime.Now.ToLongTimeString();

            if (config.program.Keys.Where(start => start >= DateTime.Now).Count() > 0)
            {
                DateTime nextProgramStart = config.program.Keys.Where(start => start >= DateTime.Now).Min();

                newDisplayText = "Next: " + config.program[nextProgramStart].Text + " " + newDisplayText;
            }


            Size newDisplayTextSize = TextRenderer.MeasureText(newDisplayText, this.marqueeTextbox1.Font);
            newDisplayTextSize.Height += 20; newDisplayTextSize.Width += 20;

            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;


            var thisSize = this.Size;

            if (Screen.PrimaryScreen.WorkingArea.Width - 10 < newDisplayTextSize.Width) {
                thisSize.Width = Screen.PrimaryScreen.WorkingArea.Width - 10;
                thisSize.Height = newDisplayTextSize.Height;
               
            } else
                thisSize = newDisplayTextSize;

            this.Size = thisSize;

            this.marqueeTextbox1.Text = newDisplayText;
            this.marqueeTextbox1.Size = thisSize;

            if (config.AutoCenterX)
            {
                Point newLocation = this.Location;

                newLocation.X = (workingRectangle.Width - thisSize.Width) / 2;

                this.Location = newLocation;
            }

            timer1.Enabled = true;

        }

        private void OnShown(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\r':
                    Application.Exit();
                    break;

                case ' ':
                    ShowConfigForm();
                    break;
            }
        }


        private void ShowConfigForm() { 

            Configuration dummy_config = config.ShallowCopy();

            ConfigForm frm = new ConfigForm(dummy_config);

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                SetConfig(frm.Config);
            }
        }
    }
}
