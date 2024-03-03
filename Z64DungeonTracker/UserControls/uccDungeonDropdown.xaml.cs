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

        public string? Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(uccDungeonDropdown), new PropertyMetadata(""));

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

        private void cmbxDropdown_MouseEnter(object sender, MouseEventArgs e)
        {
            Opacity = 1.0;
        }

        private void cmbxDropdown_MouseLeave(object sender, MouseEventArgs e)
        {
            Opacity = 0.5;
        }

        private void cmbxDropdown_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (cmbxDropdown.Foreground == dataContextVM.UnfinishedColor)
            {
                cmbxDropdown.Foreground = dataContextVM.FinishedColor;
            }
            else
            {
                cmbxDropdown.Foreground = dataContextVM.UnfinishedColor;
            }
        }
    }
}
