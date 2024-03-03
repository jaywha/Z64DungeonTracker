using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Z64DungeonTracker.ViewModel
{
    public class vmMainWindow : DependencyObject
    {
        public ObservableCollection<string> Dungeons { get; private set; }

        public vmMainWindow() {
            Dungeons = new ObservableCollection<string>() {
                "?",
                "Deku",
                "DC",
                "BOTW",
                "GTG",
                "Ice Cavern",
                "Jabu",
                "Forest",
                "Fire",
                "Water",
                "Spirit",
                "Shadow",
                "Woodfall",
                "Great Bay",
                "SnowHead",
                "Stone Tower",
                "Inverted Tower",
                "Swamp House",
                "Ocean House",
                "Ikana Castle",
                "Beneath The Well",
                "Beneath The Well Back",
                "Pirate Fortress",
                "Secret Shrine"
            };
        }

        public Brush FinishedColor { get; set; } = Brushes.Green;
        public Brush UnfinishedColor { get; set; } = Brushes.Red;
    }
}