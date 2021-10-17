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
using Newtonsoft.Json;

namespace ClickerGame
{
    public partial class frmClicker : Form
    {
        private SaveData _saveData;


        public frmClicker()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void frmApplication_Load(object sender, EventArgs e)
        {
            _saveData = Program.SaveData;

            _saveData.ShopData.Items = new()
            {
                new Item() { Name = "Google Click Bot", CookiesPerSecond = 1, Price = 50, Description = "When buying this bot you will get:\n1 click per second automatically." },
                new Item() { Name = "Juice Creator Bot", CookiesPerSecond = 2, Price = 100, Description = "When buying this bot you will get:\n2 clicks per second automatically." },
                new Item() { Name = "Stepsis", CookiesPerSecond = 5, Price = 250, Description = "When buying her you will get:\n5 clicks per second automatically" },
                new Item() { Name = "Cow Milker", CookiesPerSecond = 10, Price = 500, Description = "When buying this milker you will get:\n10 clicks per second automatically" },
                new Item() { Name = "Russian Dancer", CookiesPerSecond = 20, Price = 1000, Description = "When buying this dancer you will get:\n20 clicks per second automatically" }
            };

            UpdateUI();
        }

        private void btnClicker_Click(object sender, EventArgs e)
        {
            _saveData.CookieCount += _saveData.PointsPerClick;

            UpdateUI();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            try
            {
                frmShop f2 = new frmShop(ref _saveData);
                f2.ShowDialog();
                UpdateUI();
            }
            catch (Exception)
            {
                MessageBox.Show($"There was a problem opening the item shop. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmClicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("save.json", JsonConvert.SerializeObject(_saveData, Formatting.Indented));
        }

        private void UpdateUI()
        {
            // Give the right values to each string and item needed.
            lblClickCounter.Text = _saveData.CookieCount + "";
            lblNeededToUpgrade.Text = Convert.ToString(_saveData.ShopData.Items.Min(x => x.Price) - _saveData.CookieCount);
            if ((_saveData.ShopData.PointsNeeded - _saveData.CookieCount) <= 0)
            {
                lblNeededToUpgrade.Text = "none";
            }
            else
            {
                lblNeededToUpgrade.Text = Convert.ToString(_saveData.ShopData.PointsNeeded - _saveData.CookieCount);
            }

            lbxOwnedItems.Items.Clear();
            foreach (var item in _saveData.BoughtItems)
                lbxOwnedItems.Items.Add($"{item.Value}x {item.Key}");
        }
    }
}
