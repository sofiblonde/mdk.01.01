using AirportApp.Helpers;
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

namespace AirportApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAirports.xaml
    /// </summary>
    public partial class PageAirports : Page
    {

        Entities context = Entities.GetContext();
        List<Airports> air = Entities.GetContext().Airports.ToList();
        public PageAirports()
        {
            InitializeComponent();
            dgAirports.ItemsSource = air;

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        { 
           AppHelper.mainFrame.Navigate(new PageAddEditAirport(new Airports()));
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var selectedRep = dgAirports.SelectedItems.Cast<Airports>().ToList();

            if ((MessageBox.Show($"Удалить информацию о {selectedRep.Count} докладах?",
                "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question)
                == MessageBoxResult.Yes))
            {
                try
                {
                    context.Airports.RemoveRange(selectedRep);
                    context.SaveChanges();
                    air = context.Airports.ToList();
                    dgAirports.ItemsSource = air;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnRef_Click(object sender, RoutedEventArgs e)
        {
            air = context.Airports.ToList();
            dgAirports.ItemsSource = air;
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.mainFrame.GoBack();
        }

        private void btnChangeConf_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.mainFrame.Navigate(new PageAddEditAirport((sender as Button).DataContext as Airports));
        }
    }
}
