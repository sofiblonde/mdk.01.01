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
    /// Логика взаимодействия для PagePR1.xaml
    /// </summary>
    public partial class PagePR1 : Page
    {
        public PagePR1()
        {
            InitializeComponent();
        }

        //private void LstResultPR1_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        //{
         
        //}

        private void BtnNextPR1_Click(object sender, RoutedEventArgs e)
        {
           // NavigationService.Navigate(new Uri("PagePR2.xaml",uriKind: System.UriKind.Relative));
        }

        private void BtnSolvePR1_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(TxtPR1X.Text);
            double y = Convert.ToDouble(TxtPR1Y.Text);
            double z = Convert.ToDouble(TxtPR1Z.Text);

            double g = (Math.Pow(y, (x + 1))) / (Math.Pow(Math.Abs(y - 2), 1.0 / 3.0) + 3) + (x + y / 2) / (2 * Math.Abs(x + y)) * Math.Pow((x + 1), (-1 / Math.Sin(z)));
            LstResultPR1.Items.Add("ПР№1 ИСП.21.2А Миусова С. А.");
            LstResultPR1.Items.Add($"x={x}");
            LstResultPR1.Items.Add($"x={y}");
            LstResultPR1.Items.Add($"x={z}");
            LstResultPR1.Items.Add($"x={g}");
        }
    }
}
