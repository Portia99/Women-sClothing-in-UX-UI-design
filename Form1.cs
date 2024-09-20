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
    public partial class Form1 : Form
    {
        private Image[] imagesSet1;
        private Image[] imagesSet2;
        private bool showingFirstSet = true;
        private int fadeStep = 0;
        private int totalFadeSteps = 60;
        public Form1()
        {
            InitializeComponent();

            imagesSet1 = new Image[]
            {
                Properties.Resources.dress1,  // First image of set 1
                Properties.Resources.formal,  // Second image of set 1
                Properties.Resources.heel1,   // Third image of set 1
                Properties.Resources.jn
            };

            imagesSet2 = new Image[]
            {
                Properties.Resources.skirt1,  // First image of set 2
                Properties.Resources.shoes1,  // Second image of set 2
                Properties.Resources.short1, // Third image of set 2
                Properties.Resources.bag2,
            };
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            hPageUserControl1.BringToFront();
            
        }
        private void btnSale_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnHome.ForeColor = Color.Pink;
            hPageUserControl1.BringToFront();
            // Display the first set of images initially
            hPageUserControl1.ShowImages(imagesSet1);

            timer1.Interval = 4000;
            // Start the timer
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Start fading out the current images
            fadeStep = 0;
            timer2.Interval = 100; // Set a small interval for smooth fading
            timer2.Start();

            
        }

       

        private void hPageUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // Fade out
            fadeStep++;
            if (fadeStep <= totalFadeSteps / 2)
            {
                SetPictureBoxOpacity(1.0f - (fadeStep / (float)totalFadeSteps));
            }
            else if (fadeStep == (totalFadeSteps / 2) +1)
            {
                // Switch the images after fade out is complete
                if (showingFirstSet)
                {
                    hPageUserControl1.ShowImages(imagesSet2); // Show second set on the UserControl
                    showingFirstSet = false;
                }
                else
                {
                    hPageUserControl1.ShowImages(imagesSet1); // Show first set on the UserControl
                    showingFirstSet = true;
                }
            }
            else if (fadeStep <= totalFadeSteps)
            {
                // Fade in
                SetPictureBoxVisibility((fadeStep - totalFadeSteps / 2) / (float)totalFadeSteps);
            }
            else
            {
                // Stop the fade timer after completing the fade-in process
                timer2.Stop();
            }
        }
        private void SetPictureBoxVisibility(float visibilityFactor)
        {
            // Adjust the visibility of each PictureBox by changing its simulated opacity
            // Simulate fade using transparency or hiding/showing
            int alphaValue = (int)(visibilityFactor * 255);

            foreach (PictureBox pb in hPageUserControl1.Controls.OfType<PictureBox>())
            {
                pb.BackColor = Color.FromArgb(alphaValue, pb.BackColor); // Simulate fading with transparency
            }
        }

        private void SetPictureBoxOpacity(float opacity)
        {
            // Simulate fade by setting visibility to partially opaque
            foreach (PictureBox pb in hPageUserControl1.Controls.OfType<PictureBox>())
            {
                pb.BackColor = Color.FromArgb((int)(opacity * 255), pb.BackColor);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClothing_Click(object sender, EventArgs e)
        {
            clothingUserControl1.BringToFront();
           
        }

        private void btnShoes_Click(object sender, EventArgs e)
        {
            shoesUserControl1.BringToFront();
            
        }

        private void btnBeauty_Click(object sender, EventArgs e)
        {
            beautyUserControl1.BringToFront();
            
        }

    }
}
