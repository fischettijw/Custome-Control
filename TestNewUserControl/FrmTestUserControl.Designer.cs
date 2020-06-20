namespace TestNewUserControl
{
    partial class FrmTestUserControl
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
            this.ClrSelector = new Custome_Control.ColorSelector();
            this.LblRed = new System.Windows.Forms.Label();
            this.TxtRed = new System.Windows.Forms.TextBox();
            this.TxtGreen = new System.Windows.Forms.TextBox();
            this.LblGreen = new System.Windows.Forms.Label();
            this.TxtBlue = new System.Windows.Forms.TextBox();
            this.LblBlue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClrSelector
            // 
            this.ClrSelector.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClrSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClrSelector.ControlColor = System.Drawing.Color.Empty;
            this.ClrSelector.Location = new System.Drawing.Point(12, 12);
            this.ClrSelector.Name = "ClrSelector";
            this.ClrSelector.Size = new System.Drawing.Size(249, 304);
            this.ClrSelector.TabIndex = 0;
            this.ClrSelector.ColorChanged += new System.EventHandler(this.ClrSelector_ColorChanged);
            // 
            // LblRed
            // 
            this.LblRed.AutoSize = true;
            this.LblRed.Location = new System.Drawing.Point(316, 43);
            this.LblRed.Name = "LblRed";
            this.LblRed.Size = new System.Drawing.Size(27, 13);
            this.LblRed.TabIndex = 1;
            this.LblRed.Text = "Red";
            // 
            // TxtRed
            // 
            this.TxtRed.Location = new System.Drawing.Point(319, 68);
            this.TxtRed.Name = "TxtRed";
            this.TxtRed.ReadOnly = true;
            this.TxtRed.Size = new System.Drawing.Size(100, 20);
            this.TxtRed.TabIndex = 2;
            this.TxtRed.Text = "0";
            this.TxtRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtGreen
            // 
            this.TxtGreen.Location = new System.Drawing.Point(319, 145);
            this.TxtGreen.Name = "TxtGreen";
            this.TxtGreen.ReadOnly = true;
            this.TxtGreen.Size = new System.Drawing.Size(100, 20);
            this.TxtGreen.TabIndex = 4;
            this.TxtGreen.Text = "0";
            this.TxtGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblGreen
            // 
            this.LblGreen.AutoSize = true;
            this.LblGreen.Location = new System.Drawing.Point(316, 120);
            this.LblGreen.Name = "LblGreen";
            this.LblGreen.Size = new System.Drawing.Size(36, 13);
            this.LblGreen.TabIndex = 3;
            this.LblGreen.Text = "Green";
            // 
            // TxtBlue
            // 
            this.TxtBlue.Location = new System.Drawing.Point(319, 224);
            this.TxtBlue.Name = "TxtBlue";
            this.TxtBlue.ReadOnly = true;
            this.TxtBlue.Size = new System.Drawing.Size(100, 20);
            this.TxtBlue.TabIndex = 6;
            this.TxtBlue.Text = "0";
            this.TxtBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblBlue
            // 
            this.LblBlue.AutoSize = true;
            this.LblBlue.Location = new System.Drawing.Point(316, 199);
            this.LblBlue.Name = "LblBlue";
            this.LblBlue.Size = new System.Drawing.Size(28, 13);
            this.LblBlue.TabIndex = 5;
            this.LblBlue.Text = "Blue";
            // 
            // FrmTestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 346);
            this.Controls.Add(this.TxtBlue);
            this.Controls.Add(this.LblBlue);
            this.Controls.Add(this.TxtGreen);
            this.Controls.Add(this.LblGreen);
            this.Controls.Add(this.TxtRed);
            this.Controls.Add(this.LblRed);
            this.Controls.Add(this.ClrSelector);
            this.Name = "FrmTestUserControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Selector User Control by Joseph Fischetti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Custome_Control.ColorSelector ClrSelector;
        private System.Windows.Forms.Label LblRed;
        private System.Windows.Forms.TextBox TxtRed;
        private System.Windows.Forms.TextBox TxtGreen;
        private System.Windows.Forms.Label LblGreen;
        private System.Windows.Forms.TextBox TxtBlue;
        private System.Windows.Forms.Label LblBlue;
    }
}

