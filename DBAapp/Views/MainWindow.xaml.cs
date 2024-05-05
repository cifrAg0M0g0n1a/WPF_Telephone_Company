using DBAapp.Models;
using DBAapp.ViewModels;
using DBAapp.Views;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace DBAapp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            MainViewModel mainViewModel = new MainViewModel();
            DataGrid.ItemsSource = mainViewModel.GetMainData();
        }

        private void Streets_Click(object sender, RoutedEventArgs e)
        {
            StreetsModalWindow streetsModalWindow = new StreetsModalWindow();
            streetsModalWindow.ShowDialog();
        }

        private void ExportCSV_Click(object sender, RoutedEventArgs e)
        {
            CSVExporter cSVExporter = new CSVExporter();
            cSVExporter.ExportDataGridToCSV(DataGrid);
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel mainViewModel = new MainViewModel();
            SearchByPhoneWindow searchByPhoneWindow = new SearchByPhoneWindow();
            searchByPhoneWindow.Owner = this;

            if (searchByPhoneWindow.ShowDialog() == true)
            {
                string num = searchByPhoneWindow.PhoneNumber;

                if (num.Replace(" ", "") != "+7()--")
                {
                    List<AbonentViewModel> abonents = mainViewModel.GetMainDataByPhone(num);

                    if (abonents.Count > 0)
                    {
                        DataGrid.ItemsSource = abonents;
                    }
                    else
                    {
                        DataGrid.ItemsSource = mainViewModel.GetMainData();
                        System.Windows.MessageBox.Show("Нет абонентов, удовлетворяющих критерию поиска", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {
                    DataGrid.ItemsSource = mainViewModel.GetMainData();
                    System.Windows.MessageBox.Show("Нет абонентов, удовлетворяющих критерию поиска", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }
    }
}