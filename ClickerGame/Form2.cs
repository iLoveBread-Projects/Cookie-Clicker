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
        public static int autoClick;
        public static int pointsNeeded;

        public static string item;
        public static string selectedItem;
        public static int searchAmount;
        public static int currentPrice;
        private SaveData _saveData;

        public frmShop(ref SaveData saveData)
        {
            InitializeComponent();

            // Disable window maximization.
            this.MaximizeBox = false;

            _saveData = saveData;
            lbxItems.Items.Clear();
            foreach(var item in _saveData.ShopData.Items)
                lbxItems.Items.Add(item.Name);
        }

        private void frmShop_Load(object sender, EventArgs e)
        {
            // Set the size of the form programmatically.
            this.Width = 230;
            this.Height = 315;

            lblExplained.Text = "";
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            var item = _saveData.ShopData.Items.First(x => x.Name == selectedItem);
            var currentPrice = GetPrice(item, _saveData.BoughtItems.First(x => x.Key == selectedItem).Value);

            if (_saveData.CookieCount >= currentPrice)
            {
                try
                {
                    _saveData.CookieCount -= currentPrice;
                    if (!_saveData.BoughtItems.ContainsKey(item.Name))
                        _saveData.BoughtItems.Add(item.Name, 0);
                    else
                        _saveData.BoughtItems[item.Name]++;

                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show($"There went something wrong, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Not enought points, you need {GetPrice(item, item.Price)} points for this item.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void lbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = lbxItems.SelectedItem.ToString();
            lblExplained.Text = _saveData.ShopData.Items.First(x => x.Name == selectedItem).Description;
        }

        private int GetPrice(Item item, int currentAmount)
        {
            return item.Price * (currentAmount + 2);
        }
    }
}
