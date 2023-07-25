using NotarialHelper.Pages.Client;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Windows;
using System.Windows.Controls;

namespace NotarialHelper.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        private RecordClient _recordClient;
        private NotarialOfficeContext _dbContext;
        public ClientPage()
        {
            InitializeComponent();
            ClientsGridLoaded();

            _recordClient = new RecordClient();
        }

        private void AddClientButton_Click(object sender, RoutedEventArgs e)
        {
            _recordClient.Show();
        }

        private void ClientsGridLoaded()
        {
            _dbContext = new NotarialOfficeContext();

            var clients = from client in _dbContext.Clients
                        join deal in _dbContext.Deals
                        on client.IdClient equals deal.IdClient
                        into empty from deal in empty.DefaultIfEmpty()
                        select new
                          {
                              IdClient = client.IdClient,
                              FullName = client.FullName,
                              KindActivity = client.KindActivity,
                              Adress = client.Adress,
                              Phone = client.Phone,
                              IdDeal = deal.IdDeal,
                              Sum = deal.Sum,
                              Comission = deal.Commission,
                              Description = deal.Description
                          };
                         
            foreach (var client in clients)
            {
                ClientsGrid.Items.Add(client);
            }
        }
    }
}
