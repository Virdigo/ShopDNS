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

namespace ShopDNS.Pages
{
	/// <summary>
	/// Логика взаимодействия для PageOne.xaml
	/// </summary>
	public partial class PageOne : Page
	{
		public PageOne()
		{
			InitializeComponent();
		}

		private void dtgPayment_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}

        private void TxTSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void comein_Click(object sender, RoutedEventArgs e)
        {
            Classes.ClassFrame.frmObj.Navigate(new Pages.PageAvtorizacia());
        }
    }
}
