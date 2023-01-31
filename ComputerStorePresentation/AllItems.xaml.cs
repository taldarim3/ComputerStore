using StoreServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace ComputerStorePresentation
{
    /// <summary>
    /// Interaction logic for AllItems.xaml
    /// </summary>
    public partial class AllItems : Page
    {
        int AuthorId = 0;
        public AllItems(int AuthorId)
        {
            this.AuthorId = AuthorId;

            InitializeComponent();

            StoreServiceClient client = new StoreServiceClient();

            List<StoreServiceReference.Item1> tempItems = client.GetAllItems().ToList();

            List<ComputerStoreService.Data.Item> items = new List<ComputerStoreService.Data.Item>();
            foreach (var p in tempItems)
            {
                items.Add(new ComputerStoreService.Data.Item()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                    AuthorId= p.AuthorId,
                });
            }
            ItemsGrid.ItemsSource = items;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void StoreButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StorePage(AuthorId));
        }
    }
}
