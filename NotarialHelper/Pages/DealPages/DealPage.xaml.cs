using Microsoft.EntityFrameworkCore;
using NotarialHelper.Pages.DealPages;
using NotarialHelper.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
namespace NotarialHelper.Pages
{
    /// <summary>
    /// Логика взаимодействия для DealPage.xaml
    /// </summary>
    public partial class DealPage : Page
    {
        private RecordDeal _recordDeal;
        private NotarialOfficeContext _dbContext;
        private string _idDeal;

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

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new NotarialOfficeContext())
            {
                if(this._idDeal != null)
                {
                var deal = context.Deals.Where(d => d.IdDeal == Convert.ToInt32(this._idDeal)).Single();
                context.Deals.Remove(deal);
                context.SaveChanges();
                }
            }
        }

        private void DealsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = DealsGrid.SelectedCells[0];
            var content = (item.Column.GetCellContent(item.Item) as TextBlock).Text;
            this._idDeal = content;
        }
    }
}
