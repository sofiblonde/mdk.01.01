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
    /// Логика взаимодействия для PagePR3.xaml
    /// </summary>
    public partial class PagePR3 : Page
    {
        public PagePR3()
        {
            InitializeComponent();
        }

        private void LstResultPR3_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        private void BtnSolvePR3_Click(object sender, RoutedEventArgs e)
        {
            double X0 = double.Parse(TxtPR3X0.Text);
            double Xk = double.Parse(TxtPR3Xk.Text);
            double Dx = double.Parse(TxtPR3Dx.Text);
            double b = double.Parse(TxtPR3B.Text);
            double y;
            double x = X0;
            LstResultPR3.Items.Add("ПР№2 ИСП.21.2А Миусова С. А.");
            LstResultPR3.Items.Add($"x0={X0}");
            LstResultPR3.Items.Add($"xk={Xk}");
            LstResultPR3.Items.Add($"dx={Dx}");
            LstResultPR3.Items.Add($"b={b}");
            while (x <= (Xk + Dx) / 2)
            {
                y = Math.Pow(x, 5/2 - b) + (Math.Log10(Math.Pow(x, 2) + 12.7));
                LstResultPR3.Items.Add($"x ={x}, y={y}");
                x = x + Dx;
            }
        }

        private void BtnClearPR3_Click(object sender, RoutedEventArgs e)
        {
            TxtPR3B.Clear();
            TxtPR3Dx.Clear();
            TxtPR3X0.Clear();
            TxtPR3Xk.Clear();
            LstResultPR3.Items.Clear();
        }

        private void BtnBackPR3_Click(object sender, RoutedEventArgs e)
        {
            Classes.ClassFrame.frmObj.Navigate(new Pages.PagePR2());
        }

        private void BtnNextPR3_Click(object sender, RoutedEventArgs e)
        {
            Classes.ClassFrame.frmObj.Navigate(new Pages.PagePR4());
        }
    }
}
