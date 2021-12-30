using System.Windows;
using System.Windows.Input;
using System.ComponentModel;
using Warehouse.Classes;
using Warehouse.Classes.Models;

namespace Warehouse
{
    public partial class CustomerWindow : Window
    {
        private Backend backend;
        public CustomerWindow(Backend backend)
        {
            this.InitializeComponent();
            this.backend = backend;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.UpdateDataGrid();
        }
        private void AddCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            this.LockAllControls();
            this.backend.CustomerController.Customer = new Customer();
            EditCustomerWindow editCustomerWindow = new EditCustomerWindow(this.backend);
            editCustomerWindow.Closing += (object objectSender, CancelEventArgs cancelEventArgs) =>
            {
                this.UpdateDataGrid();
                this.UnlockAllControls();
            };
            editCustomerWindow.Show();
        }
        private void RemoveCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            this.backend.CustomerController.Remove((Customer)this.CustomerDataGrid.SelectedItem);
            this.backend.UpdateUIEventHandler.Invoke(sender, e);
            this.UpdateDataGrid();
        }
        private void CustomerDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.LockAllControls();
            this.backend.CustomerController.Customer = (Customer)this.CustomerDataGrid.SelectedItem;
            EditCustomerWindow editCustomerWindow = new EditCustomerWindow(this.backend);
            editCustomerWindow.Closing += (object objectSender, CancelEventArgs cancelEventArgs) =>
            {
                this.UpdateDataGrid();
                this.UnlockAllControls();
            };
            editCustomerWindow.Show();
        }
        private void UpdateDataGrid()
        {
            this.CustomerDataGrid.ItemsSource = null;
            this.CustomerDataGrid.ItemsSource = this.backend.CustomerController.Customers;
        }
        private void LockAllControls()
        {
            this.AddCustomerButton.Click -= this.AddCustomerButton_Click;
            this.RemoveCustomerButton.Click -= this.RemoveCustomerButton_Click;
            this.CustomerDataGrid.MouseDoubleClick -= this.CustomerDataGrid_MouseDoubleClick;
        }
        private void UnlockAllControls()
        {
            this.AddCustomerButton.Click += this.AddCustomerButton_Click;
            this.RemoveCustomerButton.Click += this.RemoveCustomerButton_Click;
            this.CustomerDataGrid.MouseDoubleClick += this.CustomerDataGrid_MouseDoubleClick;
        }
    }
}
