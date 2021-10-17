using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace ClickerGame
{
    static class Program
    {
        public static SaveData SaveData = new();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SaveData = File.Exists("save.json") ? JsonConvert.DeserializeObject<SaveData>(File.ReadAllText("save.json")) : new();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmClicker());
        }
    }
}
