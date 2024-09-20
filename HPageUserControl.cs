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
    public partial class HPageUserControl : UserControl
    {
        public HPageUserControl()
        {
            InitializeComponent();
        }

        private void HPageUserControl_Load(object sender, EventArgs e)
        {

        }
        public void ShowImages(Image[] images)
        {
            if (images.Length >= 4)
            {
                picBox1Home.Image = images[0]; // First image
                picBox2Home.Image = images[1]; // Second image
                picBox3Home.Image = images[2]; // Third image
                picBox4Home.Image = images[3]; // Fourth image
            }
        }
    }
}
