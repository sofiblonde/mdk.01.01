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
            LstResultPR2.Items.Add("ПР№2 ИСП.21.2А Миусова С. А.");
            LstResultPR2.Items.Add($"x={x}");
            LstResultPR2.Items.Add($"x={y}");
            LstResultPR2.Items.Add($"x={z}");
            LstResultPR2.Items.Add($"x={d}");
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
