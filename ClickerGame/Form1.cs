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
                new Item() { Name = "Juice Creator", CookiesPerSecond = 2, Price = 100, Description = "When buying this bot you will get:\n2 clicks per second automatically." },
                new Item() { Name = "Stepsis", CookiesPerSecond = 5, Price = 250, Description = "When buying her you will get:\n5 clicks per second automatically." },
                new Item() { Name = "Cow Milker", CookiesPerSecond = 10, Price = 500, Description = "When buying this milker you will get:\n10 clicks per second automatically." },
                new Item() { Name = "Russian Dancer", CookiesPerSecond = 20, Price = 1000, Description = "When buying this dancer you will get:\n20 clicks per second automatically." },
                new Item() { Name = "Cookie Extractor", CookiesPerSecond = 25, Price = 2500, Description = "When buying this extractor you will get:\n25 clicks per second automatically." },
                new Item() { Name = "Milky Miner", CookiesPerSecond = 35, Price = 3500, Description = "When buying this miner you will get:\n35 clicks per second automatically." },
                new Item() { Name = "Invalid Cookie Discarder", CookiesPerSecond = 50, Price = 7500, Description = "When buying this discarder you will get:\n50 clicks per second automatically." },
                new Item() { Name = "Price Checker", CookiesPerSecond = 75, Price = 15000, Description = "When buying this checker you will get:\n75 clicks per second automatically." },
                new Item() { Name = "Dad's Juice", CookiesPerSecond = 100, Price = 20000, Description = "When buying this juice you will get:\n100 clicks per second automatically." },
                new Item() { Name = "Cookie Generator", CookiesPerSecond = 150, Price = 30000, Description = "When buying this generator you will get:\n150 clicks per second automatically." },
            };
            
            // Create a timer that ticks every second.
            tmrAutoClick.Enabled = true;
            tmrAutoClick.Interval = 1000;
            tmrAutoClick.Tick += new EventHandler(OnTimerTick);

            UpdateUI();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            // Each second (interval of the timer), this will run.
            foreach (var item in _saveData.BoughtItems)
            {
                // For each item that you bought it will add clicks automatically each second.
                _saveData.CookieCount += (item.Value + 1) * _saveData.ShopData.Items.First(x => x.Name == item.Key).CookiesPerSecond;
            }

            UpdateUI();
        }

        private void btnClicker_Click(object sender, EventArgs e)
        {
            // Add clicks each time you click the button.
            _saveData.CookieCount += _saveData.PointsPerClick;

            UpdateUI();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the shop form.
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
            // Save the game progress upon closing the main form.
            File.WriteAllText("save.json", JsonConvert.SerializeObject(_saveData, Formatting.Indented));
        }

        private void UpdateUI()
        {
            // Give the right values to each string and item needed every time time the event is triggered.
            lblClickCounter.Text = _saveData.CookieCount + "";

            lbxOwnedItems.Items.Clear();

            if ((_saveData.ShopData.PointsNeeded - _saveData.CookieCount) <= 0)
            {
                lblNeededToUpgrade.Text = "none";
            }
            else
            {
                lblNeededToUpgrade.Text = Convert.ToString(_saveData.ShopData.PointsNeeded - _saveData.CookieCount);
            }

            foreach (var item in _saveData.BoughtItems)
                lbxOwnedItems.Items.Add($"{item.Value + 1}x {item.Key}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frmClickUpgrade f3 = new frmClickUpgrade();
                f3.ShowDialog();
                UpdateUI();
            }
            catch (Exception)
            {
                MessageBox.Show($"There was a problem opening the click upgrades form. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
