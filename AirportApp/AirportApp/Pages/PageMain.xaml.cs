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
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        Entities context = Entities.GetContext();
        List<Planes> orig = Entities.GetContext().Planes.ToList();
        List<Planes> current = new List<Planes>();

        public PageMain()
        {
            InitializeComponent();

            current = orig;
            DgPlanes.ItemsSource = current;

            cboxArrPoint.ItemsSource = context.Planes.ToList();
            cboxArrPoint.SelectedValue = "AirportID";
            cboxArrPoint.DisplayMemberPath = "AirportName";

            cboxDepPoint.ItemsSource = context.Planes.ToList();
            cboxDepPoint.SelectedValue = "AirportID";
            cboxDepPoint.DisplayMemberPath = "AirportName";
            

        }

        private void UpdateFilters()
        {
            current = orig.Where(x => x.PlaneNumber.Equals(int.Parse(tboxSearch.Text))).ToList();
            if (cboxArrPoint.SelectedIndex != -1) current = current.Where(x => x.Airports.AirportId == cboxArrPoint.SelectedIndex + 1).ToList();
            if (cboxDepPoint.SelectedIndex != -1) current = current.Where(x => x.Airports.AirportName == cboxDepPoint.SelectedValue.ToString()).ToList();
            DgPlanes.ItemsSource = current;
        }


        private void btnRef_Click(object sender, RoutedEventArgs e)
        {
            orig = context.Planes.ToList();
            DgPlanes.ItemsSource = orig;
        }

        private void btnToАirport_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.mainFrame.Navigate(new PageAirports());
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var selectedRep = DgPlanes.SelectedItems.Cast<Planes>().ToList();

            if ((MessageBox.Show($"Удалить информацию о {selectedRep.Count} рейсе?",
                "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question)
                == MessageBoxResult.Yes))
            {
                try
                {
                    context.Planes.RemoveRange(selectedRep);
                    context.SaveChanges();
                    orig = context.Planes.ToList();
                    DgPlanes.ItemsSource = orig;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.mainFrame.Navigate(new PageAddEditPlanes(new Planes()));
        }

        private void tboxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateFilters();
        }

        private void cboxArrPoint_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateFilters();
        }

        private void cboxDepPoint_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateFilters();
        }

        private void btnClearFilters_Click(object sender, RoutedEventArgs e)
        {
            cboxArrPoint.SelectedIndex = -1;
            cboxDepPoint.SelectedIndex = -1;
            tboxSearch.Text = "";
            current = orig;
            DgPlanes.ItemsSource = current;
        }

        private void btnChangeRep_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.mainFrame.Navigate(new PageAddEditPlanes((sender as Button).DataContext as Planes));
        }

        private void tboxSearch_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
