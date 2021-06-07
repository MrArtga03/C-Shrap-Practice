using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace LauncherForUsers
{
    public partial class UserAccount : Window
    {
        public UserAccount()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (op.ShowDialog() == true)
            {
                Image1.Source = new BitmapImage(new Uri(op.FileName));
            }
        }

        //Смена темы
        private void RadioButton_Dark_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            var brush = new SolidColorBrush(Color.FromArgb(255, (byte)34, (byte)34, (byte)38));
            if (radioButton.IsChecked == true)
            {
                Grid1.Background = brush;
            }
        }

        private void RadioButton_White_Checked_1(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.IsChecked == true)
            {
                Grid1.Background = Brushes.White;
            }
        }
    }
}
