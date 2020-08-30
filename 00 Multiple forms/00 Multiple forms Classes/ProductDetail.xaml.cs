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

namespace _00_Multiple_forms_Classes
{
    /// <summary>
    /// Interaction logic for ProductDetail.xaml
    /// </summary>
    public partial class ProductDetail : Window
    {
        public ProductDetail()
        {
            InitializeComponent();
        }

        private void txtCode_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckIfFieldsAreEmpty();
        }

        private void txtNaam_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckIfFieldsAreEmpty();

        }

        private void txtOmschrijving_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckIfFieldsAreEmpty();

        }

        private void txtPrijs_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txtPrice.Text != string.Empty)
            {
                try
                {
                    int.Parse(txtPrice.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("No valid number");
                }
            }

            CheckIfFieldsAreEmpty();

        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void CheckIfFieldsAreEmpty() {
            if (txtCode.Text != string.Empty && txtName.Text != string.Empty && txtDescription.Text != string.Empty && txtPrice.Text != string.Empty)
                btnOk.IsEnabled = true;
            else
                btnOk.IsEnabled = false;
        }
    }
}
