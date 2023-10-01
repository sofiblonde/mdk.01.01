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
    /// Логика взаимодействия для PagePR7.xaml
    /// </summary>
    public partial class PagePR7 : Page
    {
        public PagePR7()
        {
            InitializeComponent();
        }

        private void BtnResultPR7_Click(object sender, RoutedEventArgs e)
        {
           
            
            double[] numbers = { 1.5, -2.7, 0.8, -1.3, 2.1, 3.4, -4.6, 1.7, 2.9, -0.5, -1.9, 2.6, 1.2, -3.8, 0.9, 1.1, -2.4, -1.6, 2.3, 1.8, -0.7, 1.4, -2.2, -0.9, 1.6 };

            int negativeCount = 0;
            int rangeCount = 0;

            foreach (double number in numbers)
            {
                if (number < 0)
                {
                    negativeCount++;
                }

                if (number >= 1 && number <= 2)
                {
                    rangeCount++;
                }
            }
            List<string> result = new List<string>();
            result.Add("Число отрицательных элементов: " + negativeCount);
            result.Add("Число членов, принадлежащих отрезку [1,2]: " + rangeCount);
            LstResultPR7.ItemsSource = result;
           
        }
        private void BtnClearPR7_Click(object sender, RoutedEventArgs e)
        {
            
            LstResultPR7.Items.Clear();
        }
        private void BtnBackPR7_Click(object sender, RoutedEventArgs e)
        {
            Classes.ClassFrame.frmObj.Navigate(new Pages.PagePR6());
        }

        private void BtnNextPR7_Click(object sender, RoutedEventArgs e)
        {
            Classes.ClassFrame.frmObj.Navigate(new Pages.PagePR1());
        }
    }
}
