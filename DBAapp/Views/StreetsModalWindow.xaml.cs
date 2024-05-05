using DBAapp.ViewModels;
using System;
using System.Windows;

namespace DBAapp.Views
{
    /// <summary>
    /// Логика взаимодействия для StreetsModalWindow.xaml
    /// </summary>
    public partial class StreetsModalWindow : Window
    {
        public static string Value = String.Empty;

        public StreetsModalWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            MainViewModel mainViewModel = new MainViewModel();
            StreetsDataGrid.ItemsSource = mainViewModel.GetStreets();
        }
    }
}
