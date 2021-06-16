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
    public partial class AddInfo : Window
    {
        public AddInfo()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }

        //Получение данных введённых пользователем
        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            UserAccount account = new UserAccount();
            CheckIn check = new CheckIn();
            account.TextBlock3.Text = "Имя: " + Name1.Text;
            account.TextBlock4.Text = "Фамилия: " + LastName1.Text;
            account.TextBlock5.Text = "Отчество: " + Pat1.Text;
            account.TextBlock6.Text = "Пол: " + Gender.Text;
            account.TextBlock7.Text = $"Дата рождения: {DataBorInfo.Text}.{MonthBorInfo.Text}.{YearBorInfo.Text}";
            account.TextBlock8.Text = $"Email: " + Email1.Text;
            account.TextBlock9.Text = "Группа: " + Group1.Text;
            account.TextBlock10.Text = "IP: " + Guid.NewGuid();

            if (LastName1.Text.Length < 3)
            {
                LastName1.Background = Brushes.Red;
                LastName1.ToolTip = "Длина строки должна быть не менее 3 символов!";
            }
            else if (Name1.Text.Length < 3)
            {
                Name1.Background = Brushes.Red;
                Name1.ToolTip = "Длина строки должна быть не менее 3 символов!";
            }
            else if (Pat1.Text.Length < 3)
            {
                Pat1.Background = Brushes.Red;
                Pat1.ToolTip = "Длина строки должна быть не менее 3 символов!";
            }
            else if (Gender.Text == "")
            {
                Gender.ToolTip = "Выберите ваш пол!";
            }
            else if (DataBorInfo.Text == "" || MonthBorInfo.Text == "" || YearBorInfo.Text == "")
            {
                DataBorInfo.ToolTip = "Выберите вашу дату рождения!";
                MonthBorInfo.ToolTip = "Выберите ваш месяц рождения!";
                YearBorInfo.ToolTip = "Выберите ваш год рождения!";
            }
            else if (Group.Text.Length < 3)
            {
                Group.Background = Brushes.Red;
                Group.ToolTip = "Длина строки должна быть не менее 3 символов!";
            }
            else if (Email1.Text != "@" || Email1.Text != ".")
            {
                Email1.Background = Brushes.Red;
                Email1.ToolTip = " Вы упустили символы '@' или '.' ";
            }
            else
            {
                Name1.Background = Brushes.Transparent;
                LastName1.Background = Brushes.Transparent;
                Pat1.Background = Brushes.Transparent;
                Gender.Background = Brushes.Transparent;
                DataBorInfo.Background = Brushes.Transparent;
                MonthBorInfo.Background = Brushes.Transparent;
                YearBorInfo.Background = Brushes.Transparent;
                Group.Background = Brushes.Transparent;
                Email1.Background = Brushes.Transparent;
                Email1.ToolTip = "";

                account.Show();
                this.Hide();
            }
        }

        private void Button_Eng_Click(object sender, RoutedEventArgs e)
        {
            TextLogin.Text = "Your login:";
            MainTitle.Text = "Check in";
            AuthBtn.Content = "Authorization";
            InfoText.Text = "Enter additional details:";
            Name.Text = "Name";
            LastName.Text = "Last Name";
            Pat.Text = "Patronymic";
            Male.Text = "Male";
            Female.Text = "Female";
            GenderText.Text = "Gender";
            TextNumber.Text = "Number";
            TextMonth.Text = "Month";
            TextYear.Text = "Year";
            Group.Text = "Group";
            RegBtn.Content = "Ready";
            Email.Text = "Email";
        }

        private void Button_Rus_Click(object sender, RoutedEventArgs e)
        {
            TextLogin.Text = "Ваш логин:";
            MainTitle.Text = "Регистрация";
            AuthBtn.Content = "Авторизация";
            InfoText.Text = "Введите дополнительные данные:";
            Name.Text = "Имя";
            LastName.Text = "Фамилия";
            Pat.Text = "Отчества";
            Male.Text = "Мужской";
            Female.Text = "Женский";
            GenderText.Text = "Пол";
            TextNumber.Text = "Число";
            TextMonth.Text = "Месяц";
            TextYear.Text = "Год";
            Group.Text = "Группа";
            RegBtn.Content = "Готов";
            Email.Text = "Почта";
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
