using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame
{
    public class SaveData
    {
        public int PointsPerClick { get; set; } = 1;
        public int CookieCount { get; set; } = 0;
        public int ClickerCount { get; set; } = 0;
        public ShopData ShopData { get; set; } = new();
        public Dictionary<string, int> BoughtItems {get;set;} = new();
    }
    public class ShopData
    {
        public int PointsNeeded { get; set; } = 50;
        public List<Item> Items { get; set; } = new();
    }
}
