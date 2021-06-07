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
using System.Windows.Shapes;

namespace LauncherForUsers
{
    public partial class CheckIn : Window
    {
        public CheckIn()
        {
            InitializeComponent();
        }


        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            //Получение данных введёных пользователем
            string Login = TextBoxLogin.Text;
            string Pass = passBox.Password;
            string Pass2 = passBox_2.Password;

          
            //Проверка пользовательских данных
            //В случаи, если данные введены некорректно
            if (Login.Length < 5)
            {
                TextBoxLogin.ToolTip = "Длина логина должна быть не менее 5 символов!";
                TextBoxLogin.Background = Brushes.Red;
            }
            else if (Pass.Length < 5)
            {
                passBox.ToolTip = "Длина пароля должна быть не менее 5 символов!";
                passBox.Background = Brushes.Red;
            }
            else if (Pass2 != Pass)
            {
                passBox_2.ToolTip = "Пароль не совпадает!";
                passBox_2.Background = Brushes.Red;
            }
            else if (CheckBox.IsChecked == false)
            {
                TextFalse.Foreground = Brushes.Red;
                TextFalse.ToolTip = "Примите соглашение!";
            }

            //В случаи, если всё верно введено
            else
            {
                TextBoxLogin.ToolTip = "";
                TextBoxLogin.Background = Brushes.Transparent;

                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;

                passBox_2.ToolTip = "";
                passBox_2.Background = Brushes.Transparent;

                TextFalse.Foreground = Brushes.Black;

                AddInfo info = new AddInfo();
                info.LoginPlace.Text = Login;
                info.Show();
                this.Hide();
            }
        }

        private void Button_BackTo_Auth_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }

        //Пользовательское соглашение
        private void ReadInfo_Click(object sender, RoutedEventArgs e)
        {
            Termsofuse termsofuse = new Termsofuse();
            termsofuse.Show();
        }

        //Смена языка
        private void Button_Eng_Click(object sender, RoutedEventArgs e)
        {
            MainTitle.Text = "Check in";
            AuthBtn.Content = "Authorization";
            TextLogin.Text = "Enter your login";
            TextPassword.Text = "Enter your Password";
            TextPasswordRep.Text = "Repeat your Password";
            BtnReady.Content = "Ready";
            TextFalse.Text = "Accept user agreement";
            ReadInfo.Content = "Read";
        }

        private void Button_Rus_Click(object sender, RoutedEventArgs e)
        {
            MainTitle.Text = "Регистрация";
            AuthBtn.Content = "Авторизация";
            TextLogin.Text = "Введите ваш логин";
            TextPassword.Text = "Введите ваш пароль";
            TextPasswordRep.Text = "Повторно введите ваш пароль";
            BtnReady.Content = "Готово";
            TextFalse.Text = "Принять пользовательское соглашение";
            ReadInfo.Content = "Читать";
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
