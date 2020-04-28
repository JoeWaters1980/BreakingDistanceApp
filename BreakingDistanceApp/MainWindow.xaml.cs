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
using System.Windows.Navigation;
using System.Windows.Shapes;
//Joseph Waters
// breaking distance app 
//Project sem 2 2019
namespace BreakingDistanceApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {

            InitializeComponent();

        }


        private void CarEnter_Click_1(object sender, RoutedEventArgs e)
        {
            NewPage.Navigate(new Page1());
        }
    }
}