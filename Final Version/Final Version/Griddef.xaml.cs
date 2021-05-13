using System;
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
using System.Diagnostics;

namespace Final_Version
{
    /// <summary>
    /// Interaction logic for Griddef.xaml
    /// </summary>
    public partial class Griddef : Window
    {



        public int row { get; set; }
        public int column { get; set; }



        public Griddef()
        { 
            InitializeComponent();
        }

        private void GridSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            Slider slider = sender as Slider;

            if (slider != null)
            {
                this.column = (int)slider.Value;
                this.row = (int)slider.Value;
            }
        }

        private void RunApp_Click(object sender, RoutedEventArgs e)
        {
            MainWindow sW = new MainWindow(row, column);
            sW.Show();
            this.Close();
        }

        
    }
}