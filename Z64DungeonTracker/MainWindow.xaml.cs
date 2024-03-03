using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using Z64DungeonTracker.Controllers;

namespace Z64DungeonTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Test()
        {
            var userDocsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+@"\z64trackers\";
            var cfgFile = Path.Combine(userDocsPath, "z64dungeontracker.txt");
            if (File.Exists(cfgFile))
            {
                var parts = File.ReadAllText(cfgFile).Split(',');
                var connectionString = parts[0];
                var dbName = parts[1];
                var collection = parts[2];

                try
                {
                    var db = new DungeonController(connectionString, dbName, collection);
                    foreach (var dungeon in db.ReadAll())
                    {
                        Debug.WriteLine(dungeon);
                    }
                } catch(Exception e) {
                    Debug.WriteLine($"<Error> {e.Message}{Environment.NewLine}{e.Source}");
                }
            }
        }

        private void mnuiTest_Click(object sender, RoutedEventArgs e)
        {
            Test();
        }
    }
}
