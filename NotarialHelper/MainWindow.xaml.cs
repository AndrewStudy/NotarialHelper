using NotarialHelper.Pages;
using NotarialHelper.Pages.ExportPages;
using System;
using System.Windows;

namespace NotarialHelper
{
    public partial class MainWindow : Window
    {
        private ClientPage _clientPage;
        private DealPage _dealPage;
        private ServicePage _servicePage;
        private ExportToExcelPage _exportToExcelPage;
        private HomePage _homePage;

        public MainWindow()
        {
            InitializeComponent();

            _clientPage = new();
            _dealPage = new();
            _servicePage = new();
            _exportToExcelPage = new();
            _homePage = new();
        }

        private void ToExcelMenu_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = _exportToExcelPage;
        }

        private void ToDealsMenu_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = _dealPage;
        }

        private void ToServiceMenu_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = _servicePage;
        }

        private void ToClientsMenu_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = _clientPage;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = _homePage;
        }

        private void MainFrame_Loaded(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = _homePage;
        }

        private void MainFrame_ContextMenuClosing(object sender, System.Windows.Controls.ContextMenuEventArgs e)
        {

        }
    }
}
