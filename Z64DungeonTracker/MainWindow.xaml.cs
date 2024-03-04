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
                var db_configs = new List<string[]>();
                foreach (var line in File.ReadLines(cfgFile))
                {
                    db_configs.Add(line.Split(','));
                }

                // dungeons
                var parts = db_configs[0];
                var connectionString = parts[0];
                var dbName = parts[1];
                var collection = parts[2];

                try
                {
                    var db = new DungeonController(connectionString, dbName, collection);
                    foreach (var dungeon in db.GetRoom("42-bac"))
                    {
                        Debug.WriteLine(dungeon);
                    }

                    Debug.WriteLine("===========");

                    foreach (var dungeon in db.GetRoom("87-a1c"))
                    {
                        Debug.WriteLine(dungeon);
                    }
                } catch(Exception e) {
                    Debug.WriteLine($"<Error> Dungeons: {e.Message}{Environment.NewLine}{e.Source}");
                }

                // rooms
                parts = db_configs[1];
                connectionString = parts[0];
                dbName = parts[1];
                collection = parts[2];

                try
                {
                    var db = new RoomController(connectionString, dbName, collection);
                    foreach (var room in db.ReadAll())
                    {
                        Debug.WriteLine(room);
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine($"<Error> Rooms: {e.Message}{Environment.NewLine}{e.Source}");
                }
            }
        }

        private void mnuiTest_Click(object sender, RoutedEventArgs e)
        {
            Test();
        }
    }
}
