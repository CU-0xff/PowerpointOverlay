namespace CountDownApp
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.lblFont = new System.Windows.Forms.Label();
            this.btnChooseFont = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.txbMarqueeSpeed = new System.Windows.Forms.TextBox();
            this.lblMarqueeSpeed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(233, 74);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(288, 17);
            this.lblFont.TabIndex = 0;
            this.lblFont.Text = "The quick brown fox jumps over the lazy dog";
            // 
            // btnChooseFont
            // 
            this.btnChooseFont.Location = new System.Drawing.Point(25, 42);
            this.btnChooseFont.Name = "btnChooseFont";
            this.btnChooseFont.Size = new System.Drawing.Size(103, 44);
            this.btnChooseFont.TabIndex = 1;
            this.btnChooseFont.Text = "Choose Font";
            this.btnChooseFont.UseVisualStyleBackColor = true;
            this.btnChooseFont.Click += new System.EventHandler(this.btnChooseFont_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(649, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 50);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(496, 391);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(133, 50);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(25, 113);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(103, 44);
            this.btnColor.TabIndex = 4;
            this.btnColor.Text = "Text Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbMarqueeSpeed
            // 
            this.txbMarqueeSpeed.Location = new System.Drawing.Point(133, 274);
            this.txbMarqueeSpeed.Name = "txbMarqueeSpeed";
            this.txbMarqueeSpeed.Size = new System.Drawing.Size(104, 22);
            this.txbMarqueeSpeed.TabIndex = 5;
            this.txbMarqueeSpeed.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidating);
            // 
            // lblMarqueeSpeed
            // 
            this.lblMarqueeSpeed.AutoSize = true;
            this.lblMarqueeSpeed.Location = new System.Drawing.Point(22, 274);
            this.lblMarqueeSpeed.Name = "lblMarqueeSpeed";
            this.lblMarqueeSpeed.Size = new System.Drawing.Size(105, 17);
            this.lblMarqueeSpeed.TabIndex = 6;
            this.lblMarqueeSpeed.Text = "MarqueeSpeed";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMarqueeSpeed);
            this.Controls.Add(this.txbMarqueeSpeed);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChooseFont);
            this.Controls.Add(this.lblFont);
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Button btnChooseFont;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox txbMarqueeSpeed;
        private System.Windows.Forms.Label lblMarqueeSpeed;
    }
}