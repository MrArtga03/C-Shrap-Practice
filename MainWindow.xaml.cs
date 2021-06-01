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
            //"Данные реального пользователя"
            string RealUserLogin = "Ruslan228";
            string RealUserPassword = "n5ugXbPN";

            string Login = TextBoxLogin.Text;
            string Password = passBox.Password;

            if (Login.Length < 5)
            {
                TextBoxLogin.ToolTip = "Длина логина должна быть не менее 5 символов!";
                TextBoxLogin.Background = Brushes.Red;
            }
            else if (Password.Length < 5)
            {
                passBox.ToolTip = "Длина пароля должна быть не менее 5 символов!";
                passBox.Background = Brushes.Red;
            }
            else
            {
                TextBoxLogin.ToolTip = "";
                TextBoxLogin.Background = Brushes.Transparent;

                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;
            }

            //Верный ввод "Данные реального пользователя"
            if (Login == RealUserLogin && Password == RealUserPassword)
            {
                UserAccount account = new UserAccount();
                account.TextBlock4.Text = "Фамилия: Лобанов";
                account.TextBlock3.Text = "Имя: Леви";
                account.TextBlock5.Text = "Отчество: Левак";
                account.TextBlock6.Text = "Пол: Мужской";
                account.TextBlock7.Text = "Дата рождения: 1.04.2000";
                account.TextBlock8.Text = "Email: russiAoneLove2000@gmail.com";
                account.TextBlock9.Text = "Группа: 10-1П9";
                account.TextBlock10.Text = Guid.NewGuid().ToString();

                account.Show();
                this.Hide();
            }
            //Не верный ввод "Данные реального пользователя"
            else if (Login != RealUserLogin) 
            {
                TextBoxLogin.Background = Brushes.Red;
                TextBoxLogin.ToolTip = "Неверно набран логин или такого не существует!";
            }
            else if (Password != RealUserPassword)
            {
                passBox.Background = Brushes.Red;
                passBox.ToolTip = "Неверный пароль!";
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
            //TextBoxLogin.ToolTip = "Login length must be at least 5 characters!";
            //passBox.ToolTip = "Password must be at least 5 characters long!";
            //TextBoxLogin.ToolTip = "Login is incorrect or does not exist!";
            //passBox.ToolTip = "Invalid password!";
        }

        private void Button_Rus_Click(object sender, RoutedEventArgs e)
        {
            MainTitle.Text = "Авторизация";
            RegBtn.Content = "Регистрация";
            TextLogin.Text = "Введите ваш логин";
            TextPassword.Text = "Введите ваш пароль";
            ReadyBtn.Content = "Готово";
            //TextBoxLogin.ToolTip = "Длина логина должна быть не менее 5 символов!";
            //passBox.ToolTip = "Длина пароля должна быть не менее 5 символов!";
            //TextBoxLogin.ToolTip = "Неверно набран логин или такого не существует!";
            //passBox.ToolTip = "Неверный пароль!";
        }
    }
}
