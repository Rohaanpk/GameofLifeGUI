﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Final_Version
{
    /// <summary>
    /// Interaction logic for Opening.xaml
    /// </summary>
    public partial class Opening : Window
    {
        public Opening()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Griddef sW = new Griddef();
            sW.Show();
            this.Close();
        }
    }
}
