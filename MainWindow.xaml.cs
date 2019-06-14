/*
 * Conner Warboys
 * Project Euler Problem 1
 * May 12th, 2019
 * ICS3U
*/
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

namespace _185338Multiples35
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int finalsum;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click_1(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i < 334; i++)
            {
                txbMultiples.Text += i * 3 + ", ";
                finalsum += i * 3;
            }
            for(int j = 1; j < 200; j++)
            {
                txbMultiples.Text += j * 5 + ", ";
                finalsum += j * 5;
            }
            for(int l = 1; l < 67; l++)
            {
                finalsum -= l * 15;
            }
            lblFinalSum.Content = finalsum;
        }
    }
}
