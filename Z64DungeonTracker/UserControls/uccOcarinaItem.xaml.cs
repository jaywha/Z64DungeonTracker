using System;
using System.Collections.Generic;
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
using Z64DungeonTracker.Models;

namespace Z64DungeonTracker.UserControls
{
    /// <summary>
    /// Interaction logic for uccOcarinaItem.xaml
    /// </summary>
    public partial class uccOcarinaItem : UserControl
    {
        public ImageSource ItemImageSource
        {
            get { return (ImageSource)GetValue(ItemImageSourceProperty); }
            set { SetValue(ItemImageSourceProperty, value); }
        }
        
        public static readonly DependencyProperty ItemImageSourceProperty = DependencyProperty.Register("ItemImageSource", typeof(ImageSource), typeof(uccOcarinaItem), new PropertyMetadata(null));

        public EquipmentModel? DataModel { get; set; } = null;

        public uccOcarinaItem()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender != null && sender is Image)
            {
                if (e.ChangedButton == MouseButton.Left)
                {
                    imgItem.Opacity = imgItem.Opacity == 1.0d ? 0.5d : 1.0d;
                } 
                else if (e.ChangedButton == MouseButton.Right)
                {
                    // TODO: Open Notes/Extra Menu?
                }
            }
        }
    }
}
