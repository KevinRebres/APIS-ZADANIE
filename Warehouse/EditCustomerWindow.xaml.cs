using System.Windows;
using System.Windows.Input;
using Warehouse.Classes;

namespace Warehouse
{
    public partial class EditCustomerWindow : Window
    {
        private Backend backend;
        public EditCustomerWindow(Backend backend)
        {
            this.backend = backend;
            this.InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.NameTextBox.Text = this.backend.CustomerController.Customer.Name;
            this.AddressTextBox.Text = this.backend.CustomerController.Customer.Address;
            this.PhoneNumberTextBox.Text = this.backend.CustomerController.Customer.PhoneNumber;
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.backend.CustomerController.Process(this.NameTextBox.Text, this.AddressTextBox.Text, this.PhoneNumberTextBox.Text))
            {
                this.Close();
            }
        }
        private void DiscardButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
