namespace Custome_Control
{
    partial class ColorSelector
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbrRed = new System.Windows.Forms.TrackBar();
            this.LblRed = new System.Windows.Forms.Label();
            this.LblGreen = new System.Windows.Forms.Label();
            this.TbrGreen = new System.Windows.Forms.TrackBar();
            this.LblBlue = new System.Windows.Forms.Label();
            this.TbrBlue = new System.Windows.Forms.TrackBar();
            this.PnlColor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TbrRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // TbrRed
            // 
            this.TbrRed.Location = new System.Drawing.Point(23, 45);
            this.TbrRed.Maximum = 255;
            this.TbrRed.Name = "TbrRed";
            this.TbrRed.Size = new System.Drawing.Size(203, 45);
            this.TbrRed.TabIndex = 0;
            this.TbrRed.TickFrequency = 4;
            this.TbrRed.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // LblRed
            // 
            this.LblRed.AutoSize = true;
            this.LblRed.Location = new System.Drawing.Point(23, 26);
            this.LblRed.Name = "LblRed";
            this.LblRed.Size = new System.Drawing.Size(27, 13);
            this.LblRed.TabIndex = 1;
            this.LblRed.Text = "Red";
            // 
            // LblGreen
            // 
            this.LblGreen.AutoSize = true;
            this.LblGreen.Location = new System.Drawing.Point(23, 80);
            this.LblGreen.Name = "LblGreen";
            this.LblGreen.Size = new System.Drawing.Size(36, 13);
            this.LblGreen.TabIndex = 3;
            this.LblGreen.Text = "Green";
            // 
            // TbrGreen
            // 
            this.TbrGreen.Location = new System.Drawing.Point(23, 96);
            this.TbrGreen.Maximum = 255;
            this.TbrGreen.Name = "TbrGreen";
            this.TbrGreen.Size = new System.Drawing.Size(203, 45);
            this.TbrGreen.TabIndex = 2;
            this.TbrGreen.TickFrequency = 4;
            this.TbrGreen.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // LblBlue
            // 
            this.LblBlue.AutoSize = true;
            this.LblBlue.Location = new System.Drawing.Point(23, 128);
            this.LblBlue.Name = "LblBlue";
            this.LblBlue.Size = new System.Drawing.Size(28, 13);
            this.LblBlue.TabIndex = 5;
            this.LblBlue.Text = "Blue";
            // 
            // TbrBlue
            // 
            this.TbrBlue.Location = new System.Drawing.Point(23, 147);
            this.TbrBlue.Maximum = 255;
            this.TbrBlue.Name = "TbrBlue";
            this.TbrBlue.Size = new System.Drawing.Size(203, 45);
            this.TbrBlue.TabIndex = 4;
            this.TbrBlue.TickFrequency = 4;
            this.TbrBlue.Scroll += new System.EventHandler(this.Tbr_Scroll);
            // 
            // PnlColor
            // 
            this.PnlColor.Location = new System.Drawing.Point(26, 198);
            this.PnlColor.Name = "PnlColor";
            this.PnlColor.Size = new System.Drawing.Size(199, 77);
            this.PnlColor.TabIndex = 6;
            // 
            // ColorSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.PnlColor);
            this.Controls.Add(this.LblBlue);
            this.Controls.Add(this.TbrBlue);
            this.Controls.Add(this.LblGreen);
            this.Controls.Add(this.TbrGreen);
            this.Controls.Add(this.LblRed);
            this.Controls.Add(this.TbrRed);
            this.Name = "ColorSelector";
            this.Size = new System.Drawing.Size(249, 304);
            ((System.ComponentModel.ISupportInitialize)(this.TbrRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbrBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar TbrRed;
        private System.Windows.Forms.Label LblRed;
        private System.Windows.Forms.Label LblGreen;
        private System.Windows.Forms.TrackBar TbrGreen;
        private System.Windows.Forms.Label LblBlue;
        private System.Windows.Forms.TrackBar TbrBlue;
        private System.Windows.Forms.Panel PnlColor;
    }
}
