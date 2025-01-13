using System;
using System.CodeDom;
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
using Z64DungeonTracker.ViewModel;

namespace Z64DungeonTracker.UserControls
{
    /// <summary>
    /// Interaction logic for uccOcarinaItemView.xaml
    /// </summary>
    public partial class uccOcarinaItemView : UserControl
    {
        private List<uccOcarinaItem> OcarinaItemList = new List<uccOcarinaItem>();
        private readonly string ImageFilePath;

        public vmOcarinaItemView dataContextVM = new vmOcarinaItemView();

        public uccOcarinaItemView()
        {
            InitializeComponent();
            ImageFilePath = "/Images/Items/oot_items/";
            DataContext = dataContextVM;

            InitItemImages();
        }

        public void InitItemImages()
        {
            var itemImageNameEnumerator = dataContextVM.ItemImageNames.GetEnumerator();
            itemImageNameEnumerator.MoveNext(); // get first element
            foreach (var gridItem in grdItems.Children)
            {
                if (gridItem != null && gridItem is uccOcarinaItem ocarinaItem)
                {
                    var itemName = itemImageNameEnumerator.Current;
                    //TODO: Make item name a string array dependency property on uccOcarinaItem
                    //....: This will allow user to cycle through the item states of that item.
                    if (itemName.Contains('|'))
                    {
                        itemName = itemName.Split("|")[0];
                    }
                    var itemBitmap = new BitmapImage(new Uri($"{ImageFilePath}{itemName}.jpg", UriKind.Relative));
                    ocarinaItem.SetValue(uccOcarinaItem.ItemImageSourceProperty, itemBitmap);
                    OcarinaItemList.Add(ocarinaItem);
                    itemImageNameEnumerator.MoveNext();
                }
            }
        }
    }
}
