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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TableManager
{
    /// <summary>
    /// Логика взаимодействия для EditOrderPage.xaml
    /// </summary>
    public partial class EditOrderPage : Page
    {
        public EditOrderPage()
        {
            InitializeComponent();
        }

        private void buttonAddDish_Click(object sender, RoutedEventArgs e)
        {
            //adding dish
        }

        private void buttonCompleteOrder_Click(object sender, RoutedEventArgs e)
        {
            //save all changes and go back to the main page
            NavigationService.Navigate(new TablesPage());
        }

        private void buttonDeleteDish_Click(object sender, RoutedEventArgs e)
        {
            //deleting dish
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            //navigates back to the main page
            NavigationService.Navigate(new TablesPage());
        }
    }
}