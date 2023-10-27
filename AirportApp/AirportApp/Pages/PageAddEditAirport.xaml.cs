using AirportApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для PageAddEditAirport.xaml
    /// </summary>
    public partial class PageAddEditAirport : Page
    {

        Entities context = Entities.GetContext();
        Airports air;

        public PageAddEditAirport(Airports airports)
        {
            air = airports;
            InitializeComponent();

            DataContext = air;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (air.AirportId == 0 && context.Airports.FirstOrDefault(x => x.AirportName == air.AirportName) == null) context.Airports.Add(air);
                context.SaveChanges();
                MessageBox.Show("Данные сохранены");
                AppHelper.mainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.mainFrame.GoBack();
        }
    }
}
