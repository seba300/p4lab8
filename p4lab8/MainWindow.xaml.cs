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

namespace p4lab8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RegistrationViewModel _registrationViewModel { get; set; }
        private FakeDb _dbContext { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            _registrationViewModel = new RegistrationViewModel();
            this.DataContext = _registrationViewModel;
            _dbContext = new FakeDb();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_registrationViewModel.Password != _registrationViewModel.RepeatedPassword)
            {
                MessageBox.Show("Password are different", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!_registrationViewModel.TermsAccepted)
            {
                MessageBox.Show("You must accepted", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var newUser = new UserAccount()
            {
                Username = _registrationViewModel.Login,
                PasswordHash = _registrationViewModel.Password.ToLower(),
                BirthDate = _registrationViewModel.BirthDate,
                TermsAcceptedDate = DateTime.Now,
                AccountCreationDate = DateTime.Now
            };
            _dbContext.AddUser(newUser);
            _registrationViewModel.Login = string.Empty;
            _registrationViewModel.Password = string.Empty;
            _registrationViewModel.RepeatedPassword = string.Empty;
        }
    }
}
