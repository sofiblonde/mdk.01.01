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
    /// Логика взаимодействия для PagePR2.xaml
    /// </summary>
    public partial class PagePR2 : Page
    {
        public PagePR2()
        {
            InitializeComponent();
        }

        private void LstResultPR2_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {
            
        }

        private void BtnSolvePR2_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(TxtPR2X.Text);
            double y = Convert.ToDouble(TxtPR2Y.Text);
            double z = Convert.ToDouble(TxtPR2Z.Text);

            double d = x + y + z;
            LstResultPR2.Items.Add("ПР№2 ИСП.21.2А Миусова С. А. Вариант 4");
            LstResultPR2.Items.Add($"x={x}");
            LstResultPR2.Items.Add($"y={y}");
            LstResultPR2.Items.Add($"z={z}");
            int n = 0;
            if (RbtShxPR2.IsChecked == true) n = 1;
            else if (RbtX2PR2.IsChecked == true) n = 2;
            switch (n)
            {
                case 0:
                    if (x>y) d = Math.Pow(((Math.Exp(x) - Math.Exp(-x)) / 2) - y, 3) + Math.Atan((Math.Exp(x) - Math.Exp(-x)) / 2);
                    else if (x<y) d = Math.Pow(y-((Math.Exp(x) - Math.Exp(-x)) / 2), 3) + Math.Atan((Math.Exp(x) - Math.Exp(-x)) / 2);
                    else d = Math.Pow(y + ((Math.Exp(x) - Math.Exp(-x)) / 2), 3)+ 0.5;
                    LstResultPR2.Items.Add($"Результат d={Math.Round(d, 3)}");
                    break;
                case 1:
                    if (x>y) d = Math.Pow(Math.Pow(x,2)- y, 3) + Math.Atan(Math.Pow(x, 2));
                    else if (x<y) d = Math.Pow(y-Math.Pow(x, 2), 3) + Math.Atan(Math.Pow(x, 2));
                    else d = Math.Pow(y + (Math.Pow(x, 2)), 3)+ 0.5;
                    LstResultPR2.Items.Add($"Результат d={Math.Round(d, 3)}");
                    break;
                case 2:
                    if (x > y) d = Math.Pow(Math.Exp(x) - y, 3) + Math.Atan(Math.Exp(x));
                    else if (x < y) d = Math.Pow(y - Math.Exp(x), 3) + Math.Atan(Math.Exp(x));
                    else d = Math.Pow(y + (Math.Exp(x)), 3) + 0.5;
                    LstResultPR2.Items.Add($"Результат d={Math.Round(d, 3)}");
                    break;
                default:
                    LstResultPR2.Items.Add("Решение не найдено");
                    break;
            }

        }

        private void BtnClearPR2_Click(object sender, RoutedEventArgs e)
        {
            TxtPR2X.Clear();
            TxtPR2Y.Clear();
            TxtPR2Z.Clear();
            LstResultPR2.Items.Clear();
        }
        
        private void BtnBackPR2_Click(object sender, RoutedEventArgs e)
        {
            Classes.ClassFrame.frmObj.Navigate(new Pages.PagePR1());
        }

        private void BtnNextPR2_Click(object sender, RoutedEventArgs e)
        {
           Classes.ClassFrame.frmObj.Navigate(new Pages.PagePR3());
        }
    }
}
