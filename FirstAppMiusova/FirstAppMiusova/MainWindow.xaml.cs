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

namespace FirstAppMiusova
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Classes.ClassFrame.frmObj = FrmMain;

            //Переход на страницу авторизации
            Classes.ClassFrame.frmObj.Navigate(new Pages.PageAuthorisation());
            //Classes.ClassFrame.frmObj.Navigate(new Windows.WindowRegistration());
        }

        private void BtnHello_Click(object sender, RoutedEventArgs e)
        {
            //Диалоговое окно сообщения
            MessageBox.Show("Здравствуйте! Всего хорошего!");
        }
    }
}
