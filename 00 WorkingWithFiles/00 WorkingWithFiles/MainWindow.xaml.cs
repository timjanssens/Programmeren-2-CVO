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

namespace _00_WorkingWithFiles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lbxProductsAvailable.ItemsSource = Product.ProductList;
            lbxProductsInBasket.ItemsSource = Article.ArticleList;
        }





        private void btnCloseShop_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnAddProductToAvailable_Click(object sender, RoutedEventArgs e)
        {
            frmProductDetail screen = new frmProductDetail();
            screen.Owner = this;
            screen.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            screen.ShowDialog();

            if (screen.DialogResult.HasValue && screen.DialogResult.Value)
            {
                Product.ProductList.Add(new Product(screen.txtProductCode.Text, screen.txtProductName.Text, double.Parse(screen.txtProductPrice.Text)));

            }


            lbxProductsAvailable.Items.Refresh();
        }

        private void btnRemoveProductFromAvailable_Click(object sender, RoutedEventArgs e)
        {


            Product producToDelete = (Product)lbxProductsAvailable.SelectedItem;

            Product.ProductList.Remove(producToDelete);


            lbxProductsAvailable.Items.Refresh();
        }

        private void lbxProductsAvailable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbxProductsAvailable.SelectedItem != null)
            {
                btnRemoveProductFromAvailable.IsEnabled = true;
                btnAddProductToBasket.IsEnabled = true;
            }
            else
            {
                btnRemoveProductFromAvailable.IsEnabled = false;
                btnAddProductToBasket.IsEnabled = false;
            }
        }

        private void btnAddProductToBasket_Click(object sender, RoutedEventArgs e)
        {
            frmQuantityBuyProduct screen = new frmQuantityBuyProduct();
            screen.Owner = this;
            screen.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            screen.ShowDialog();

            Product productToAdd = (Product)lbxProductsAvailable.SelectedItem;
            Article.ArticleList.Add(new Article(int.Parse(screen.txtNumberOfProductToBuy.Text), productToAdd.Code, productToAdd.Name, productToAdd.Price));

            lbxProductsInBasket.Items.Refresh();

        }
    }





























}
