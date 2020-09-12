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
using System.Windows.Shapes;

namespace _00_WorkingWithFiles
{
    /// <summary>
    /// Interaction logic for frmProductDetail.xaml
    /// </summary>
    public partial class frmProductDetail : Window
    {
        public frmProductDetail()
        {
            InitializeComponent();
            txtProductCode.Focus();
        }

        private void btnSaveAddProduct_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void btnCancelAddProduct_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void CheckIfFieldsAreEmpty()
        {
            if(txtProductPrice.Text != string.Empty && txtProductCode.Text != string.Empty && txtProductName.Text != string.Empty)
            {
                btnSaveAddProduct.IsEnabled = true;
            }
            else
                btnSaveAddProduct.IsEnabled = false;

        }

        private void txtProductCode_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckIfFieldsAreEmpty();
        }

        private void txtProductName_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckIfFieldsAreEmpty();

        }

        private void txtProductPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtProductPrice.Text != string.Empty)
            {
                try
                {
                    double.Parse(txtProductPrice.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("No valid number");
                }
            }
            CheckIfFieldsAreEmpty();

        }
    }
}
