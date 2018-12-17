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

namespace OOP_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TransactionWindow addTransaction = new TransactionWindow();
        JewelryWindow addJewelry = new JewelryWindow();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnInventoryClick(object sender, RoutedEventArgs e)
        {
            addJewelry.Show();
            this.Hide();
        }

        private void btnAddTransactionClick(object sender, RoutedEventArgs e)
        {
            addTransaction.Show();
            this.Hide();
        }
    }
}
