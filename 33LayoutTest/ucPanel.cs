using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33LayoutTest
{
    public partial class ucPanel : UserControl
    {
        public event EventHandler eLableDoubleClikcHandler;

        public ucPanel()
        {
            InitializeComponent();
        }

        private void PanelSizeChange(object sender, EventArgs e)
        {
            lblPanel.Text = string.Format("({0},{1})", lblPanel.Width, lblPanel.Height);
        }

        private void lblPanel_DoubleClick(object sender, EventArgs e)
        {
            // ucPanel자체를 인수로 넘김
            eLableDoubleClikcHandler(this, e);
        }
    }
}
