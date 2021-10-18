using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGame
{
    public partial class frmClickUpgrade : Form
    {
        public frmClickUpgrade()
        {
            InitializeComponent();
        }

        private void frmClickUpgrade_Load(object sender, EventArgs e)
        {
            this.Width = 300;
            this.Height = 200;

            UpdateUI();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {

        }

        private void UpdateUI()
        {
            lblUpgradeAmount.Text = Convert.ToString(tbrUpgradeAmount.Value + " clicks per button press");
            lblUpgradeCost.Text = "";
        }
    }
}
