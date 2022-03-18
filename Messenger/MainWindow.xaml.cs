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
using System.IO;
using System.Text.RegularExpressions;



namespace Messenger
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        static string path = @"C:\Users\Student\Downloads\Messenger\Messenger.txt";
        string last_time;
        string fileName = "Messenger.txt";
        public async void Obnovlenie()
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                //panel.text;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    panel.Text += "\n" + line;
                }

            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Obnovlenie();
            var watcher = new FileSystemWatcher(@"C:\Users\Student\Downloads\Messenger\Messenger.txt");

            watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            watcher.Changed += OnChanged;
            

            watcher.Filter = "*.txt";
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;



        }
        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            Obnovlenie();
            
        }
        /*
        private void send_Click(object sender, RoutedEventArgs e)
        {
            Regex reg = new Regex(@"\S+$");
            Match match = reg.Match(Nickname.Text);

            bool tr = false;

            if (match.Success)
            {
                tr = true;
            }

            if (!match.Success)
            {
                tr = false;
            }

            if (tr == true)
            {
                
            }
        }
        */
        private void panel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

