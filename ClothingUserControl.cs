using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WomensClothing
{
    public partial class ClothingUserControl : UserControl
    {
        public event EventHandler PanelClicked;
        public ClothingUserControl()
        {
            InitializeComponent();
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            dressUserControl1.Visible = true;
            dressUserControl1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
