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

namespace HiddenIdentity
{
    public partial class page1 : PhoneApplicationPage

    {
        int i;
        
        public page1()
        {
            InitializeComponent();
        }

        private void playbutton_Click(object sender, RoutedEventArgs e)
        {

         
        }
        public void Each_Tick(object o, EventArgs sender)
        {
            i++;
            
        }

        private void exitbutton_Click(object sender, RoutedEventArgs e)
        {
            
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
