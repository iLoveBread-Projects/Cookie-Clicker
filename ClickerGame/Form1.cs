using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace ClickerGame
{
    public partial class frmClicker : Form
    {
        public static int count;
        public static int prgValue;
        public static int pointsPerClick;

        public static int neededToUpgrade;
        public static int autoClick;

        public frmClicker()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void frmApplication_Load(object sender, EventArgs e)
        {
            // Give the right values to each string and item needed.
            lblClickCounter.Text = "none";
            pointsPerClick = 1;

            frmShop.pointsNeeded = 50;
            neededToUpgrade = frmShop.pointsNeeded;
            lblNeededToUpgrade.Text = Convert.ToString(neededToUpgrade - count);
        }

        private void btnClicker_Click(object sender, EventArgs e)
        {
            count += pointsPerClick;
            lblClickCounter.Text = Convert.ToString(count);

            if ((neededToUpgrade - count) <= 0)
            {
                lblNeededToUpgrade.Text = "none";
            }
            else
            {
                lblNeededToUpgrade.Text = Convert.ToString(neededToUpgrade - count);
            }
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            try
            {
                frmShop f2 = new frmShop();
                f2.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show($"There was a problem opening the item shop. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
