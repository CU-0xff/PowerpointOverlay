﻿namespace CountDownApp
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Configuration config;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.marqueeTextbox1 = new CountDownApp.MarqueeTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeTextbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // marqueeTextbox1
            // 
            this.marqueeTextbox1.Color = System.Drawing.Color.Empty;
            this.marqueeTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marqueeTextbox1.Location = new System.Drawing.Point(2, 2);
            this.marqueeTextbox1.Name = "marqueeTextbox1";
            this.marqueeTextbox1.Size = new System.Drawing.Size(850, 205);
            this.marqueeTextbox1.Speed = 1;
            this.marqueeTextbox1.TabIndex = 1;
            this.marqueeTextbox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 443);
            this.Controls.Add(this.marqueeTextbox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.onLoad);
            this.Shown += new System.EventHandler(this.OnShown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.marqueeTextbox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.Timer timer1;
        private MarqueeTextbox marqueeTextbox1;
    }
}

