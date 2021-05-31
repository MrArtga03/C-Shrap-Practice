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

namespace LauncherForUsers
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Ready_Click(object sender, RoutedEventArgs e)
        {
            string Login = TextBoxLogin.Text;
            string Password = passBox.Password;

            if (Login.Length < 5)
            {
                TextBoxLogin.ToolTip = "Длина логина должна быть не менее 5 символов";
                TextBoxLogin.Background = Brushes.Red;
            }
            else if (Password.Length < 5)
            {
                passBox.ToolTip = "Длина пароля должна быть не менее 5 символов";
                passBox.Background = Brushes.Red;
            }
            else
            {
                TextBoxLogin.ToolTip = "";
                TextBoxLogin.Background = Brushes.Transparent;

                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;
            }
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            CheckIn check = new CheckIn();
            check.Show();
            this.Hide();
        }

        //Смена языка
        private void Button_Eng_Click(object sender, RoutedEventArgs e)
        {
            MainTitle.Text = "Authorization";
            RegBtn.Content = "Check in";
            TextLogin.Text = "Enter your login";
            TextPassword.Text = "Enter your Password";
            ReadyBtn.Content = "Ready";
        }

        private void Button_Rus_Click(object sender, RoutedEventArgs e)
        {
            MainTitle.Text = "Авторизация";
            RegBtn.Content = "Регистрация";
            TextLogin.Text = "Введите ваш логин";
            TextPassword.Text = "Введите ваш пароль";
            ReadyBtn.Content = "Готово";
        }
    }
}
