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

namespace WpfApp67
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string numbers = "1234567890";
        string letters = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
        int count = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void fullname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (fullname.Text.Length >= 10)
            {
                foreach(char a in fullname.Text)
                {
                    if(a==' ')
                    {
                        count++;
                    }
                }
                foreach (char a in fullname.Text)
                {

                    if (numbers.Contains(a) || letters.Contains(a))
                    {
                        fullname.Background = new SolidColorBrush(Color.FromRgb(176, 6, 6));
                    }
                    else if (count == 2)
                    {
                        fullname.Background = new SolidColorBrush(Color.FromRgb(6, 176, 37));
                    }

                    else fullname.Background = new SolidColorBrush(Color.FromRgb(176, 6, 6));
                }
                count = 0;
            }
            else
            {
                fullname.Background = new SolidColorBrush(Color.FromRgb(176, 6, 6));
            }
        }

        private void birthday_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (birthday.Text.Length == 10)
            {
                try
                {
                    Convert.ToDateTime(birthday.Text);
                    birthday.Background = new SolidColorBrush(Color.FromRgb(6, 176, 37));
                }
                catch
                {
                    birthday.Background = new SolidColorBrush(Color.FromRgb(176, 6, 6));
                }
            }
            else
            {
                birthday.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            }
        }

        private void postbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (postbox.Text.Length >= 10)
            {
                foreach(char a in postbox.Text)
                {
                    count++;
                }
                if (postbox.Text.Contains("@")&&count==1)
                {
                    if (postbox.Text.IndexOf('@') > 4 && postbox.Text.Length - postbox.Text.IndexOf('@') > 3)
                    {
                        postbox.Background = new SolidColorBrush(Color.FromRgb(6, 176, 37));
                    }
                }
                else
                {
                    postbox.Background = new SolidColorBrush(Color.FromRgb(176, 6, 6));
                }
            }
            else
            {
                postbox.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));

            }
            count = 0;
        }
    }
}
