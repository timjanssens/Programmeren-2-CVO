using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace _00_Multiple_forms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int value = 80;
        public MainWindow()
        {
            InitializeComponent();
            showResult();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            value += GetValue();
            showResult();
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            value -= GetValue();
            showResult();
        }

        public int GetValue()
        {            
            value = int.Parse(lblSolution.Content.ToString());
            Choose_Value screen = new Choose_Value();

            screen.Owner = this;
            screen.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            
            screen.ShowDialog();

            if (screen.DialogResult.HasValue && screen.DialogResult.Value)
                return int.Parse(screen.txtValue.Text);
            return 0;
        }

        public void showResult()
        {
            lblSolution.Content = value.ToString();
        }
    }
}
