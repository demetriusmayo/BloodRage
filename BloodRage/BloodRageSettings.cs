using PoeHUD.Hud.Settings;
using PoeHUD.Plugins;
using System.Windows.Forms;
namespace BloodRage
{
    public class BloodRageSettings : SettingsBase
    {
        public BloodRageSettings()
        {
            //delay = new RangeNode<int>(4, 1, 10);
            pressedKey = Keys.E;
        }
       
        [Menu("Key", 1)]
        public HotkeyNode pressedKey { get; set; }

        //[Menu("Delay After Pressing Key", 2)]
        //public RangeNode<int> delay { get; set; }
    }
}
