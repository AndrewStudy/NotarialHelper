using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using NotarialHelper.Pages;

namespace NotarialHelper.Pages.Client
{
    /// <summary>
    /// Логика взаимодействия для RecordClient.xaml
    /// </summary>
    public partial class RecordClient : Window
    {
        private const int GWL_STYLE = -16;
        private const int WS_SYSMENU = 0x80000;
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        public RecordClient()
        {
            InitializeComponent();

            
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            var hwnd = new WindowInteropHelper(this).Handle;
            SetWindowLong(hwnd, GWL_STYLE, GetWindowLong(hwnd, GWL_STYLE) & ~WS_SYSMENU);
        }

        private void ClosePageButton_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        private void NextInputDataButton_Click(object sender, RoutedEventArgs e)
        {
            //TODO: ВАЛИДАЦИЯ

            using (var context = new NotarialOfficeContext())
            {
                var client = new NotarialHelper.Client()
                {
                    FullName = FullNameTextBox.Text,
                    KindActivity = ActivityTextBox.Text,
                    Adress = AdressTextBox.Text,
                    Phone = PhoneTextBox.Text
                };

                context.Clients.Add(client);
                context.SaveChanges();

                var dialogResult = MessageBox.Show(
                    "Клиент успешно создан!\nСоздать еще одну запись?", "Добавление клиента в базу",
                    MessageBoxButton.YesNo, MessageBoxImage.Asterisk);
                if(dialogResult == MessageBoxResult.Yes)
                {

                }
                else
                {
                    ClosePageButton_Click(sender,e);
                }

            }
        }
    }
}
