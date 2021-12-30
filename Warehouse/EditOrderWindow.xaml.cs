using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using Warehouse.Classes;
using Warehouse.Classes.Models;

namespace Warehouse
{
    public partial class EditOrderWindow : Window
    {
        private Backend backend;
        public EditOrderWindow(Backend backend)
        {
            this.backend = backend;
            this.InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.CustomerNameComboBox.ItemsSource = this.backend.CustomerController.Customers;
            this.ProductNameComboBox.ItemsSource = this.backend.ProductController.Products;
            this.CustomerNameComboBox.SelectedItem = this.backend.CustomerController.Customers.Find(customer => customer.Id == this.backend.OrderController.Order.CustomerId);
            this.ProductNameComboBox.SelectedItem = this.backend.ProductController.Products.Find(product => product.Id == this.backend.OrderController.Order.ProductId);
            this.QuantityTextBox.Text = Convert.ToString(this.backend.OrderController.Order.Quantity);
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = (Customer)this.CustomerNameComboBox.SelectedItem;
            Product product = (Product)this.ProductNameComboBox.SelectedItem;
            if (this.backend.OrderController.Process(this.QuantityTextBox.Text, customer, product))
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
        private void QuantityTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
