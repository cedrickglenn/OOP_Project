﻿using System;
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

namespace OOP_Project
{
    /// <summary>
    /// Interaction logic for TransactionWindow.xaml
    /// </summary>
    public partial class TransactionWindow : Window
    {
        CustomerWindow addCustomer = new CustomerWindow();
        public TransactionWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            addCustomer.Show();
        }
        
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cmbProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
