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
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace HiddenIdentity
{
    public partial class Page2 : PhoneApplicationPage

    {

        System.Windows.Threading.DispatcherTimer myDispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        int a = 0;
        int i;
        public Page2()
        {
            InitializeComponent();
            myDispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 600);
            myDispatcherTimer.Tick += new EventHandler(Each_Tick);
            myDispatcherTimer.Start();
            
          
        }
        public void Each_Tick(object o, EventArgs sender)
        {
            myblock.Text = " " + i++.ToString();
            if (i > 100)
            {
                NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));
                myDispatcherTimer.Stop();
            }
        }

       

        private void ab1(object sender, RoutedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            sum.Opacity = 0;
            a++;
            if (a >= 7)
            {
                NavigationService.Navigate(new Uri("/Page6.xaml", UriKind.Relative));
            }
           
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ang2.Opacity = 0;
            a++;
            if (a >= 7)
            {
                NavigationService.Navigate(new Uri("/Page6.xaml", UriKind.Relative));
            }
           
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ang3.Opacity = 0;
            a++;
            if (a >= 7)
            {
                NavigationService.Navigate(new Uri("/Page6.xaml", UriKind.Relative));
            }
           
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ang4.Opacity = 0;
            a++;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            ang5.Opacity = 0;
            a++;
            if (a >= 7)
            {
                NavigationService.Navigate(new Uri("/Page6.xaml", UriKind.Relative));
            }
           
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            ang6.Opacity = 0;
            a++;
            if (a >= 7)
            {
                NavigationService.Navigate(new Uri("/Page6.xaml", UriKind.Relative));
            }
           
        }

        private void total_Click(object sender, RoutedEventArgs e)
        {
            a++;
            if (a >= 7)
            {
                NavigationService.Navigate(new Uri("/Page6.xaml", UriKind.Relative));
            }
           
        }

        private void total_Click_1(object sender, RoutedEventArgs e)
        {
            a++;
            if (a >= 7)
            {
                NavigationService.Navigate(new Uri("/Page6.xaml", UriKind.Relative));
            }
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            //BitmapImage myimage = new BitmapImage(new Uri("/HiddenIdentity;component/l11.jpg", UriKind.Relative));
            sum.Opacity = 0;
            a++;
            if (a >= 7)
            {
                NavigationService.Navigate(new Uri("/loose.xaml", UriKind.Relative));
            }
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            ang2.Opacity = 0;
            a++;
            if (a >= 7)
            {
                NavigationService.Navigate(new Uri("/loose.xaml", UriKind.Relative));
            }
        }

        private void button3_Click_1(object sender, RoutedEventArgs e)
        {
            ang3.Opacity = 0;
            a++;
            if (a >= 7)
            {
                NavigationService.Navigate(new Uri("/loose.xaml", UriKind.Relative));
            }
        }

        private void button4_Click_1(object sender, RoutedEventArgs e)
        {
            ang4.Opacity = 0;
            a++;
            if (a >= 7)
            {
                NavigationService.Navigate(new Uri("/loose.xaml", UriKind.Relative));
            }
        }

        private void button5_Click_1(object sender, RoutedEventArgs e)
        {
            ang5.Opacity = 0;
            a++;
            if (a >= 7)
            {
                NavigationService.Navigate(new Uri("/loose.xaml", UriKind.Relative));
            }
        }

        private void button6_Click_1(object sender, RoutedEventArgs e)
        {
            ang6.Opacity = 0;
            a++;
            if (a >= 7)
            {
                NavigationService.Navigate(new Uri("/loose.xaml", UriKind.Relative));
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (ang2.Opacity == 0 && ang3.Opacity == 0)
            {
                if (sum.Opacity == 0 && ang4.Opacity == 0)
                {
                    if (ang5.Opacity == 0 && ang6.Opacity == 0)
                    {
                        NavigationService.Navigate(new Uri("/loose.xaml", UriKind.Relative));
                    }
                }

            }
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