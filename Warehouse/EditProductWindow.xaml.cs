using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Warehouse.Classes;

namespace Warehouse
{
    public partial class EditProductWindow : Window
    {
        private Backend backend;
        public EditProductWindow(Backend backend)
        {
            this.backend = backend;
            this.InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.NameTextBox.Text = Convert.ToString(this.backend.ProductController.Product.Name);
            if (this.backend.ProductController.Product.Quantity != 0) this.QuantityTextBox.Text = Convert.ToString(this.backend.ProductController.Product.Quantity);
            if (this.backend.ProductController.Product.Price != 0.0)  this.PriceTextBox.Text = Convert.ToString(this.backend.ProductController.Product.Price);
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.backend.ProductController.Process(this.NameTextBox.Text, this.QuantityTextBox.Text, this.PriceTextBox.Text))
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
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void PriceTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[,][0-9]+$|^[0-9]*[,]{0,1}[0-9]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }
    }
}
