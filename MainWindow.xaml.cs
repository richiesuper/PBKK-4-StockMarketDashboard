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

namespace StockMarketDashboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            gridDashboard.Visibility = Visibility.Visible;
            gridPortfolio.Visibility = Visibility.Collapsed;
            gridMarket.Visibility = Visibility.Collapsed;
            gridProfile.Visibility = Visibility.Collapsed;
            gridSettings.Visibility = Visibility.Collapsed;
        }

        private void btnDashboard_Click(object sender, RoutedEventArgs e)
        {
            gridDashboard.Visibility = Visibility.Visible;
            gridPortfolio.Visibility = Visibility.Collapsed;
            gridMarket.Visibility = Visibility.Collapsed;
            gridProfile.Visibility = Visibility.Collapsed;
            gridSettings.Visibility = Visibility.Collapsed;
        }

        private void btnPortfolio_Click(object sender, RoutedEventArgs e)
        {
            gridDashboard.Visibility = Visibility.Collapsed;
            gridPortfolio.Visibility = Visibility.Visible;
            gridMarket.Visibility = Visibility.Collapsed;
            gridProfile.Visibility = Visibility.Collapsed;
            gridSettings.Visibility = Visibility.Collapsed;
        }

        private void btnMarket_Click(object sender, RoutedEventArgs e)
        {
            gridDashboard.Visibility = Visibility.Collapsed;
            gridPortfolio.Visibility = Visibility.Collapsed;
            gridMarket.Visibility = Visibility.Visible;
            gridProfile.Visibility = Visibility.Collapsed;
            gridSettings.Visibility = Visibility.Collapsed;
        }

        private void btnProfile_Click(object sender, RoutedEventArgs e)
        {
            gridDashboard.Visibility = Visibility.Collapsed;
            gridPortfolio.Visibility = Visibility.Collapsed;
            gridMarket.Visibility = Visibility.Collapsed;
            gridProfile.Visibility = Visibility.Visible;
            gridSettings.Visibility = Visibility.Collapsed;
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            gridDashboard.Visibility = Visibility.Collapsed;
            gridPortfolio.Visibility = Visibility.Collapsed;
            gridMarket.Visibility = Visibility.Collapsed;
            gridProfile.Visibility = Visibility.Collapsed;
            gridSettings.Visibility = Visibility.Visible;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void titleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
