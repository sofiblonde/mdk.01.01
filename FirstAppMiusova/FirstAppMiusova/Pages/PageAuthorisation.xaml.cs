using FirstAppMiusova.Windows;
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

namespace FirstAppMiusova.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAuthorisation.xaml
    /// </summary>
    public partial class PageAuthorisation : Page
    {
        public PageAuthorisation()
        {
            InitializeComponent();
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            WindowRegistration windowRegistration = new WindowRegistration();
            windowRegistration.Show();
        }

        private void BtnAuth_Click(object sender, RoutedEventArgs e)
        {
            //ввод данных из текстовых полей
            string login = TxtLogin.Text;
            string password = PsbPassword.Password;
            
            //проверка логина и пароля
            if (login.ToLower() == "admin" ) 
            {
                if (password == "1")
                {
                    MessageBox.Show("Вход выполнен!");
                }
                else
                {
                    MessageBox.Show("Неверный пароль!");
                }
            }
            else
            {
                MessageBox.Show("Введены неверные данные!");
            }
        }
    }
}
