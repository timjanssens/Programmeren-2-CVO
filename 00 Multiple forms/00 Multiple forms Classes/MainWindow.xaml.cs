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

namespace _00_Multiple_forms_Classes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //link the listProduct in WPF to the list of products of the class
            lstProducts.ItemsSource = Product.Products;
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            AddProductToList();
            RefreshLstProducts();
        }

        private void AddProductToList()
        {
            //Open new window
            ProductDetail screen = new ProductDetail();
            screen.Owner = this;
            screen.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            screen.ShowDialog();

            //create object of product with all fields
            try
            {
                if (screen.DialogResult.HasValue && screen.DialogResult.Value)
                {
                    Product.Products.Add(new Product(screen.txtCode.Text, screen.txtName.Text, screen.txtDescription.Text, int.Parse(screen.txtPrice.Text)));

                }
            }
            catch (Exception)
            {
                MessageBox.Show("You didn't use a valid number as price!");
            }
        }

        private void RefreshLstProducts()
        {
            //lstProducts.Items.Clear();
            //foreach (var item in Product.Products)
            //{
            //    lstProducts.Items.Add(item.ToString());
            //}

            lstProducts.Items.Refresh();
        }
        /// <summary>
        /// When a inserted product is clicked in the list, the buttons delete and select are enabled 
        /// </summary>
        private void EnableDisableButtons()
        {
            if (lstProducts.SelectedItem != null)
            {
                btnChangeProduct.IsEnabled = true;
                btnRemoveProduct.IsEnabled = true;
            }
            else
            {
                btnChangeProduct.IsEnabled = false;
                btnRemoveProduct.IsEnabled = false;
            }
        }

        private void lstProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EnableDisableButtons();
        }

        private void btnChangeProduct_Click(object sender, RoutedEventArgs e)
        {
            Product productToChange = (Product)lstProducts.SelectedItem;

            //Open new window
            ProductDetail screen = new ProductDetail();
            screen.Owner = this;
            screen.WindowStartupLocation = WindowStartupLocation.CenterOwner;

            //populate fields with data from product
            screen.txtCode.Text = productToChange.Code;
            screen.txtDescription.Text = productToChange.Description;
            screen.txtName.Text = productToChange.Name;
            screen.txtPrice.Text = productToChange.Price.ToString();

            screen.ShowDialog();

            //create object of product with all fields
            try
            {
                if (screen.DialogResult.HasValue && screen.DialogResult.Value)
                {
                    Product.Products.Add(new Product(screen.txtCode.Text, screen.txtName.Text, screen.txtDescription.Text, int.Parse(screen.txtPrice.Text)));

                    Product.Products.Remove(productToChange);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You didn't use a valid number as price!");
            }
            RefreshLstProducts();
        }

        private void btnRemoveProduct_Click(object sender, RoutedEventArgs e)
        {
            //select the object
            Product productToDelete = (Product)lstProducts.SelectedItem;

            //show messagebox and ask if you want to delete product
            if (MessageBox.Show($"Are you sure you want to delete {productToDelete.Name} ?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                //remove seleted object from list
                Product.Products.Remove(productToDelete);
                RefreshLstProducts();
            }
        }
    }
}
