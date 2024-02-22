using MaterialDesignExtensions.Controls;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Z64DungeonTracker.ViewModel;

namespace Z64DungeonTracker.UserControls
{
    /// <summary>
    /// Interaction logic for uccDungeonDropdown.xaml
    /// </summary>
    public partial class uccDungeonDropdown : UserControl
    {
        public vmMainWindow dataContextVM { get; } = new();

        public uccDungeonDropdown()
        {
            InitializeComponent();
            DataContext = dataContextVM;
        }

        public void ReadConfigFile()
        {
            OpenFileDialog dlgSelectConfig = new OpenFileDialog();
            //dlgSelectConfig.ShowDialog()

            dataContextVM.Dungeons.Clear();
        }
    }
}
