using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDownApp
{
    class MarqueeTextbox : PictureBox
    {

        private Timer MarqueeTimer;
        public int Speed { get; set; }

        private string _Text;
        public string Text
        {
            set { this._Text = value; this.displayTextSize = TextRenderer.MeasureText(value, this.Font); }
            get { return this._Text; }
        }
        public Color Color { get; set; }

        public void Start() { MarqueeTimer.Start(); }
        public void Stop() { MarqueeTimer.Stop(); }

        private int offset;
        private Size displayTextSize; 

        public MarqueeTextbox()
        {
            this.Font = SystemFonts.DefaultFont;

            displayTextSize = this.Size;

            Speed = 1;
            MarqueeTimer = new Timer();
            MarqueeTimer.Interval = 25;
            MarqueeTimer.Enabled = true;
            MarqueeTimer.Tick += (aSender, eArgs) =>
            {
                offset = (offset - Speed);
                if (offset < -this.displayTextSize.Width) offset = 0;
                this.Invalidate();
            };
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            //base.OnPaint(pe);
            TextRectangleF(pe);
        }

        public void TextRectangleF(PaintEventArgs e)

        {

            // Create font and brush.

            SolidBrush drawBrush = new SolidBrush(this.Color);

            // Create rectangle for drawing.

            RectangleF drawRect = new RectangleF(0, 0, this.Width, this.Height);

            // Draw string to screen.
            e.Graphics.DrawString(this.Text, this.Font, drawBrush, offset, 0);
            e.Graphics.DrawString(this.Text, this.Font, drawBrush,
                                 this.displayTextSize.Width + offset, 0);


        }
    }
}
