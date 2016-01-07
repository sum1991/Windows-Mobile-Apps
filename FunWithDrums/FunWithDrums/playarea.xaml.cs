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
    public partial class playarea : PhoneApplicationPage
    {
        public playarea()
        {
            InitializeComponent();
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("go to main page?", "Exit", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            { NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative)); }
            else if (result == MessageBoxResult.Cancel)
            { e.Cancel = true; }

        }
    }



}