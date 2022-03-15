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

namespace WpfApp66
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Cifri="1234567890";
        string English = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FIO_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (FIO.Text != "")
            {
                foreach (char a in FIO.Text)
                {
                
                    if (Cifri.Contains(a) || English.Contains(a))
                    {
                        FIOProgress.Foreground = new SolidColorBrush(Color.FromRgb(176, 6, 6));
                    }
                    else
                    {
                        FIOProgress.Foreground = new SolidColorBrush(Color.FromRgb(6, 176, 37));
                    }
                }
            }
            else
            {
                FIOProgress.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            }

        }

        private void Date_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Date.Text != "")
            {
                try
                {
                    Convert.ToDateTime(Date.Text);
                    DateProgress.Foreground = new SolidColorBrush(Color.FromRgb(6, 176, 37));
                }
                catch
                {
                    DateProgress.Foreground = new SolidColorBrush(Color.FromRgb(176, 6, 6));
                }
            }
            else
            {
                DateProgress.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            }
        }

        private void Mail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Mail.Text!="")
            {


                if (Mail.Text.Contains("@") && Mail.Text.Length > 5)
                {
                    MailProgress.Foreground = new SolidColorBrush(Color.FromRgb(6, 176, 37));
                }
                else
                {
                    MailProgress.Foreground = new SolidColorBrush(Color.FromRgb(176, 6, 6));
                }
            }
            else
            {
                DateProgress.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
               
            }
        }
    }
}
