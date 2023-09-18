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

namespace FirstAppMiusova.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagePR6.xaml
    /// </summary>
    public partial class PagePR6 : Page
    {
        public PagePR6()
        {
            InitializeComponent();
        }

        private void BtnListFromFilePR6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnResultPR6_Click(object sender, RoutedEventArgs e)
        {

                
            StreamReader sr = new StreamReader(@"Строки.txt", Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                LstInputPR6.Items.Add(sr.ReadLine());
            }
        }

        private void BtnClearPR6_Click(object sender, RoutedEventArgs e)
        {
            LstInputPR6.Items.Clear();  
        }

        private void BtnBackPR6_Click(object sender, RoutedEventArgs e)
        {
            Classes.ClassFrame.frmObj.Navigate(new Pages.PagePR3());
        }

        private void BtnNextPR6_Click(object sender, RoutedEventArgs e)
        {
            //Classes.ClassFrame.frmObj.Navigate(new Pages.PagePR6());
        }
    }
}
