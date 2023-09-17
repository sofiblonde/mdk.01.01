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
            double X0 = Convert.ToDouble(TxtPR3X0.Text);
            double Xk = Convert.ToDouble(TxtPR3Xk.Text);
            double Dx = Convert.ToDouble(TxtPR3Dx.Text);
            double A = Convert.ToDouble(TxtPR3A.Text);

            double b = X0 + Xk + Dx + A;
            LstResultPR3.Items.Add("ПР№2 ИСП.21.2А Миусова С. А.");
            LstResultPR3.Items.Add($"x={X0}");
            LstResultPR3.Items.Add($"x={Xk}");
            LstResultPR3.Items.Add($"x={Dx}");
            LstResultPR3.Items.Add($"x={A}");
            LstResultPR3.Items.Add($"x={b}");
        }

        private void BtnClearPR3_Click(object sender, RoutedEventArgs e)
        {
            TxtPR3A.Clear();
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
