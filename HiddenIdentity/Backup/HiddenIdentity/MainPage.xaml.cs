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
    public partial class MainPage : PhoneApplicationPage
    {
        System.Windows.Threading.DispatcherTimer myDispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        int i = 0;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            myDispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            myDispatcherTimer.Tick += new EventHandler(Each_Tick);
            myDispatcherTimer.Start();
        }
        public void Each_Tick(object o, EventArgs sender)
        {
            i++;
            if (i > 5)
            {
                NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));
                myDispatcherTimer.Stop();
            }
        }
    }


}