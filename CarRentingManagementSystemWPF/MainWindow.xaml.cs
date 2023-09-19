using Repository.Repository;
using Repository.Repository.Imp;
using System;
using System.Windows;

namespace CarRentingManagementSystemWPF
{
    public partial class MainWindow : Window
    {
        private readonly ICustomerRepository _customerRepository;
        public MainWindow()
        {
            InitializeComponent();
            _customerRepository = new CustomerRepository();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var customer = _customerRepository.Login(emailinput.Text, txtPassword.Password);
                if (customer != null)
                {
                    MessageBox.Show("Login Thanh cong");
                }
            }
            catch (Exception ex)
            {

                errorMessage.Text = ex.Message;
            }
        }
    }
}
