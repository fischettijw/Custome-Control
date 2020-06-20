using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custome_Control
{
    public partial class ColorSelector : UserControl
    {
        private Color controlColor;
        public event EventHandler ColorChanged;
        public Color ControlColor
        {
            get { return controlColor; }
            set { controlColor = value; }
        }

        protected virtual void OnColorChanged(EventArgs e)
        {
            ColorChanged?.Invoke(this, e);
        }

        public ColorSelector()
        {
            InitializeComponent();
        }

        private void Tbr_Scroll(object sender, EventArgs e)
        {
            int redValue = TbrRed.Value;
            int greenValue = TbrGreen.Value;
            int blueValue = TbrBlue.Value;

            Color ctrlColor = Color.FromArgb(redValue, greenValue, blueValue);

            PnlColor.BackColor = ctrlColor;
            controlColor = ctrlColor;
            OnColorChanged(EventArgs.Empty);

        }
    }
}
