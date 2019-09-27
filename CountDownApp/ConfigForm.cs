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
    public partial class ConfigForm : Form
    {
        public Configuration Config;

        public ConfigForm(Configuration config)
        {
            Config = config;

            InitializeComponent();

            this.lblFont.Font = new System.Drawing.Font(Config.FontName, Config.FontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFont.ForeColor = Config.FontColor;

            this.txbMarqueeSpeed.Text = this.Config.MarqueeSpeed.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = Config.FontColor;

            var result = dlg.ShowDialog();

            if (result == DialogResult.OK) { Config.FontColor = dlg.Color; this.lblFont.ForeColor = Config.FontColor; }
            }

        private void btnOK_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnChooseFont_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.Font = new System.Drawing.Font(Config.FontName, Config.FontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            var result = dlg.ShowDialog();

            if(result == DialogResult.OK)
            {
                Config.FontName = dlg.Font.Name;
                Config.FontSize = dlg.Font.Size;
                this.lblFont.Font = new System.Drawing.Font(Config.FontName, Config.FontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            }
        }

        private void OnValidating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(this.txbMarqueeSpeed.Text, out int n) &&  n >= 0) this.Config.MarqueeSpeed = int.Parse(txbMarqueeSpeed.Text);
            else this.txbMarqueeSpeed.Text = this.Config.MarqueeSpeed.ToString();
        }
    }
}
