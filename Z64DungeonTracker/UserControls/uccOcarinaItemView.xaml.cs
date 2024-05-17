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

namespace Z64DungeonTracker.UserControls
{
    /// <summary>
    /// Interaction logic for uccOcarinaItemView.xaml
    /// </summary>
    public partial class uccOcarinaItemView : UserControl
    {
        public double[,] Items { get; set; } = new double[,] {
            { 0.5d, 0.5d, 0.5d, 0.5d, 0.5d, 0.5d }, 
            { 0.5d, 0.5d, 0.5d, 0.5d, 0.5d, 0.5d }, 
            { 0.5d, 0.5d, 0.5d, 0.5d, 0.5d, 0.5d }, 
            { 0.5d, 0.5d, 0.5d, 0.5d, 0.5d, 0.5d } 
        };

        public uccOcarinaItemView()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender != null && sender is Image)
            {
                if (e.ChangedButton == MouseButton.Left)
                {
                    var img = (sender as Image)!;
                    var indexes = img.Tag.ToString()!.Split(',');
                    var currOpac = Items[int.Parse(indexes[0]), int.Parse(indexes[1])];

                    if (currOpac == 1.0d)
                    {
                        img.Opacity = 0.5d;
                        Items[int.Parse(indexes[0]), int.Parse(indexes[1])] = 0.5d;
                    }
                    else
                    {
                        img.Opacity = 1.0d;
                        Items[int.Parse(indexes[0]), int.Parse(indexes[1])] = 1.0d;
                    }
                } else if (e.ChangedButton == MouseButton.Right)
                {

                }
            }
        }
    }
}
