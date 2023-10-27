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
    /// Логика взаимодействия для PageAddEditPlanes.xaml
    /// </summary>
    public partial class PageAddEditPlanes : Page
    {
        Entities context = Entities.GetContext();
        Planes planes;

        public PageAddEditPlanes(Planes plane)
        {
            planes = plane; 
            InitializeComponent();

            DataContext = planes;

            cboxAirDeparture.ItemsSource = context.Airports.ToList();
            cboxAirDeparture.SelectedValuePath = "AirpotId";
            cboxAirDeparture.DisplayMemberPath = "AirpotName";

            cboxAirDeparture.ItemsSource = context.Airports.ToList();
            cboxAirPointDestination.SelectedValuePath = "AirpotId";
            cboxAirPointDestination.DisplayMemberPath = "AirpotName";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (planes.PlaneID == 0 && context.Planes.FirstOrDefault(x => x.PlaneNumber == planes.PlaneNumber) == null) context.Planes.Add(planes);
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
