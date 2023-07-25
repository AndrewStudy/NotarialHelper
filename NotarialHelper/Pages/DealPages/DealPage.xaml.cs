using Microsoft.EntityFrameworkCore;
using NotarialHelper.Pages.DealPages;
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

namespace NotarialHelper.Pages
{
    /// <summary>
    /// Логика взаимодействия для DealPage.xaml
    /// </summary>
    public partial class DealPage : Page
    {
        private RecordDeal _recordDeal;
        private NotarialOfficeContext _dbContext;

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public DealPage()
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        {
            InitializeComponent();
            DealsGridLoaded();

            _recordDeal = new();
        }

        private void AddClientButton_Click(object sender, RoutedEventArgs e)
        {
            _recordDeal.Show();
        }


        private void DealsGridLoaded()
        {
            _dbContext = new NotarialOfficeContext();

            var deals = from deal in _dbContext.Deals
                          join client in _dbContext.Clients
                          on deal.IdClient equals client.IdClient
                          join service in _dbContext.Services
                          on deal.IdService equals service.IdService
                          select new
                          {
                            IdDeal = deal.IdDeal,
                            NameClient = client.FullName,
                            NameService = service.Name,
                            SumDeal = deal.Sum,
                            ComissionDeal = deal.Commission,
                            Description = deal.Description
                          };

            foreach (var deal in deals)
            {
                DealsGrid.Items.Add(deal);
            }
        }
    }
}
