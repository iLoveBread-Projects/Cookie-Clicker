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
    public partial class frmShop : Form
    {
        public static int f1Points;
        public static int f1AutoClick;
        public static int pointsNeeded;

        public static string item;
        public static string selectedItem;
        public static int searchAmount;

        public frmShop()
        {
            InitializeComponent();
            this.MaximizeBox = false;

            f1Points = frmClicker.count;
            f1AutoClick = frmClicker.autoClick;
        }

        private void frmShop_Load(object sender, EventArgs e)
        {
            this.Width = 230;
            this.Height = 315;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (f1Points >= pointsNeeded)
            {
                try
                {
                    f1Points -= pointsNeeded;

                    switch (selectedItem)
                    {
                        default:
                            break;
                        case "Google Click Bot":
                            f1AutoClick = 1;
                            break;
                        case "Juice Creator Bot":
                            f1AutoClick = 2;
                            break;
                        case "Stepsis":
                            f1AutoClick = 5;
                            break;
                        case "Cow Milker":
                            f1AutoClick = 10;
                            break;
                        case "Russian Dancer":
                            f1AutoClick = 20;
                            break;
                    }

                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show($"There went something wrong, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Not enought points, you need {pointsNeeded} for this item.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void lbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = lbxItems.SelectedItem.ToString();

            switch (selectedItem)
            {
                default:
                    break;
                case "Google Click Bot":
                    lblExplained.Text = "When buyinh this bot you will get:\n1 click per second automatically.";
                    pointsNeeded = 50;
                    break;
                case "Juice Creator Bot":
                    lblExplained.Text = "When buying this bot you will get:\n2 clicks per second automatically.";
                    pointsNeeded = 100;
                    break;
                case "Stepsis":
                    lblExplained.Text = "When buying her you will get:\n5 clicks per second automatically";
                    pointsNeeded = 250;
                    break;
                case "Cow Milker":
                    lblExplained.Text = "When buying this milker you will get:\n10 clicks per second automatically";
                    pointsNeeded = 500;
                    break;
                case "Russian Dancer":
                    lblExplained.Text = "When buying this dancer you will get:\n20 clicks per second automatically";
                    pointsNeeded = 1000;
                    break;
            }
        }
    }
}
