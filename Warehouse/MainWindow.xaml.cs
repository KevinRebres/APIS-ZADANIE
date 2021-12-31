using System;
using System.Windows;
using System.Windows.Input;
using System.ComponentModel;
using Warehouse.Classes;
using Warehouse.Classes.Models;

namespace Warehouse
{
    public partial class MainWindow : Window
    {
        private Backend backend = new Backend();
        public MainWindow()
        {
            this.InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.backend.UpdateUIEventHandler += this.UpdateDataGrid;
            this.LockAllControls();
        }
        private void ConnectButton_Click(object sender, RoutedEventArgs e)
        {
            this.LockAllControls();
            this.backend.UpdateUIEventHandler.Invoke(null, null);
            this.UnlockAllControls();
        }
        private void CustomerButton_Click(object sender, RoutedEventArgs e)
        {
            this.LockAllControls();
            CustomerWindow editCustomerWindow = new CustomerWindow(this.backend);
            editCustomerWindow.Closing += (object objectSender, CancelEventArgs cancelEventArgs) =>
            {
                this.backend.UpdateUIEventHandler.Invoke(null, null);
                this.UnlockAllControls();
            };
            editCustomerWindow.Show();
        }
        private void PlotButton_Click(object sender, RoutedEventArgs e)
        {
            this.PlotButton.Click -= this.PlotButton_Click;
            PlotWindow plotWindow = new PlotWindow(this.backend);
            plotWindow.Closing += (object objectSender, CancelEventArgs cancelEventArgs) =>
            {
                this.PlotButton.Click += this.PlotButton_Click;
            };
            plotWindow.Show();
        }
        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            this.LockAllControls();
            this.backend.ProductController.Product = new Product();
            EditProductWindow editProductWindow = new EditProductWindow(this.backend);
            editProductWindow.Closing += (object objectSender, CancelEventArgs cancelEventArgs) =>
            {
                this.backend.UpdateUIEventHandler.Invoke(null, null);
                this.UnlockAllControls();
            };
            editProductWindow.Show();
        }
        private void RemoveProductButton_Click(object sender, RoutedEventArgs e)
        {
            this.backend.ProductController.Remove((Product)this.ProductDataGrid.SelectedItem);
            this.backend.UpdateUIEventHandler.Invoke(null, null);
        }
        private void CreateOrderButton_Click(object sender, RoutedEventArgs e)
        {
            this.LockAllControls();
            this.backend.OrderController.Order = new Order();
            EditOrderWindow editOrderWindow = new EditOrderWindow(this.backend);
            editOrderWindow.Closing += (object objectSender, CancelEventArgs cancelEventArgs) =>
            {
                this.backend.UpdateUIEventHandler.Invoke(null, null);
                this.UnlockAllControls();
            };
            editOrderWindow.Show();
        }
        private void DeleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            this.backend.OrderController.Remove((Order)this.OrderDataGrid.SelectedItem);
            this.backend.UpdateUIEventHandler.Invoke(null, null);
        }
        private void ProductDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.LockAllControls();
            this.backend.ProductController.Product = (Product)this.ProductDataGrid.SelectedItem;
            EditProductWindow editProductWindow = new EditProductWindow(this.backend);
            editProductWindow.Closing += (object objectSender, CancelEventArgs cancelEventArgs) =>
            {
                this.backend.UpdateUIEventHandler.Invoke(null, null);
                this.UnlockAllControls();
            };
            editProductWindow.Show();
        }
        private void OrderDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.LockAllControls();
            this.backend.OrderController.Order = (Order)this.OrderDataGrid.SelectedItem;
            EditOrderWindow editOrderWindow = new EditOrderWindow(this.backend);
            editOrderWindow.Closing += (object objectSender, CancelEventArgs cancelEventArgs) =>
            {
                this.backend.UpdateUIEventHandler.Invoke(null, null);
                this.UnlockAllControls();
            };
            editOrderWindow.Show();
        }
        private void UpdateDataGrid(object sender, EventArgs e)
        {
            this.backend.CustomerController.Load();
            this.backend.ProductController.Load();
            this.backend.OrderController.Load();
            this.OrderDataGrid.ItemsSource = null;
            this.OrderDataGrid.ItemsSource = this.backend.OrderController.Orders;
            this.ProductDataGrid.ItemsSource = null;
            this.ProductDataGrid.ItemsSource = this.backend.ProductController.Products;
        }
        private void LockAllControls()
        {
            this.CustomerButton.Click -= this.CustomerButton_Click;

            this.AddProductButton.Click -= this.AddProductButton_Click;
            this.RemoveProductButton.Click -= this.RemoveProductButton_Click;

            this.CreateOrderButton.Click -= this.CreateOrderButton_Click;
            this.DeleteOrderButton.Click -= this.DeleteOrderButton_Click;

            this.ProductDataGrid.MouseDoubleClick -= this.ProductDataGrid_MouseDoubleClick;
            this.OrderDataGrid.MouseDoubleClick -= this.OrderDataGrid_MouseDoubleClick;
        }
        private void UnlockAllControls()
        {
            this.CustomerButton.Click += this.CustomerButton_Click;

            this.AddProductButton.Click += this.AddProductButton_Click;
            this.RemoveProductButton.Click += this.RemoveProductButton_Click;

            this.CreateOrderButton.Click += this.CreateOrderButton_Click;
            this.DeleteOrderButton.Click += this.DeleteOrderButton_Click;

            this.ProductDataGrid.MouseDoubleClick += this.ProductDataGrid_MouseDoubleClick;
            this.OrderDataGrid.MouseDoubleClick += this.OrderDataGrid_MouseDoubleClick;
        }
    }
}
