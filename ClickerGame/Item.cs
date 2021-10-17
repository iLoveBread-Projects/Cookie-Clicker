using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame
{
    public class Item
    {
        public string Name { get; set; } = "Unknown item";
        public int CookiesPerSecond { get; set; } = 0;
        public int Price { get; set; } = 0;
        public string Description { get; set; } = "No description";
    }
}
