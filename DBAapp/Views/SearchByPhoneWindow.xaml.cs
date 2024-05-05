using System.Windows;

namespace DBAapp.Views
{
    /// <summary>
    /// Логика взаимодействия для SearchByPhoneWindow.xaml
    /// </summary>
    public partial class SearchByPhoneWindow : Window
    {
        public string PhoneNumber { get; private set; }

        public SearchByPhoneWindow()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            PhoneNumber = phoneTextBox.Text;
            DialogResult = true;
        }
    }
}
