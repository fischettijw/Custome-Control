using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestNewUserControl
{
    public partial class FrmTestUserControl : Form
    {
        public FrmTestUserControl()
        {
            InitializeComponent();

        }

        private void ClrSelector_ColorChanged(object sender, EventArgs e)
        {
            TxtRed.Text = ClrSelector.ControlColor.R.ToString();
            TxtGreen.Text = ClrSelector.ControlColor.G.ToString();
            TxtBlue.Text = ClrSelector.ControlColor.B.ToString();
        }
    }
}
