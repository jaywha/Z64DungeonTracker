using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Z64DungeonTracker.ViewModel
{
    public class vmOcarinaItemView : DependencyObject
    {
        public ObservableCollection<string> ItemNames { get; private set; }
        public ObservableCollection<string> ItemImageNames { get; private set; }

        public vmOcarinaItemView()
        {
            ItemNames = new ObservableCollection<string>() {
                "Deku Stick", "Deku Nut", "Bombs", "Fairy Bow", "Fire Arrow", "Din's Fire",
                "Fairy Slingshot", "Fairy Ocarina|Ocarina of Time", "Bombchu", "Hookshot|Longshot", "Ice Arrow", "Farore's Wind",
                "Boomerang", "Lens of Truth", "Magic Beans", "Megaton Hammer", "Light Arrow", "Nayru's Love",
                "Bottle", "Bottle", "Bottle", "Bottle", "Adult Trade Item", "Child Trade Item"
            };

            ItemImageNames = new ObservableCollection<string>() { 
                "deku_stick", "deku_nut", "bomb", "bow", "arrow_fire", "dins_fire",
                "slingshot", "ocarina_fairy|ocarina_time", "bombchu", "hookshot|longshot", "arrow_ice", "farores_wind",
                "boomerang", "lens", "magic_bean", "hammer", "arrow_light", "nayrus_love",
                "bottle_empty", "bottle_empty", "bottle_empty", "bottle_empty", "egg_a", "egg_c"
            };
        }
    }
}
