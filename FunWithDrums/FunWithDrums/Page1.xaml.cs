using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace FunWithDrums
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/helparea.xaml", UriKind.Relative));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/playarea.xaml", UriKind.Relative));
        }
        public class ExitException : Exception { }
        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("Quit the game?", "Quit", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                throw new ExitException();

            }
            else if (result == MessageBoxResult.Cancel)
            {
                e.Cancel = false;

                NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));

            }

        }
        


    }

}