using ComputerStoreService;
using StoreServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ComputerStorePresentation
{
    /// <summary>
    /// Interaction logic for StorePage.xaml
    /// </summary>
    public partial class StorePage : Page
    {
        int AutorId { get; set; }
        List<String> search;
        public StorePage(int id)
        {
            NavigationCommands.BrowseBack.InputGestures.Clear();
            NavigationCommands.BrowseForward.InputGestures.Clear();
            this.AutorId = id;
            this.search = new List<String>();
            InitializeComponent();

            RefreshCombobox();
            
        }
        //Кнопка Поиска по Id
        private void FindById_Click(Object sender, RoutedEventArgs e)
        {
            if (IdTextBox.Text != "")
            {

                string name = IdTextBox.Text;

                StoreServiceClient client = new StoreServiceClient();
                try
                {

                    StoreServiceReference.Item temp = client.GetItemByName(name);
                    if (temp != null)
                    {
                        IdBlock.Text = temp.ItemId.ToString();
                        NameBlock.Text = temp.ItemName;
                        PriceBlock.Text = temp.ItemPrice.ToString();
                        DescriptionBlock.Text = temp.ItemDescription;
                    }

                }
                catch (FaultException ex)
                {
                    MessageBox.Show("Что-то пошло не так! " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                finally
                {
                    client.Abort();
                }
            }

        }
        //Кнопка добавления нового Item в бд
        private void AddItem_Click(Object sender, RoutedEventArgs e)
        {

            StoreServiceClient client = new StoreServiceClient();

            try
            {
                client.AddItem(AddNameBlock.Text, int.Parse(AddPriceBlock.Text), AddDescriptionBock.Text, AutorId);
            }
            catch (FaultException ex)
            {
                MessageBox.Show("Что-то пошло не так! " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                client.Abort();
                AddDescriptionBock.Text = "";
                AddNameBlock.Text = "";
                AddPriceBlock.Text = "";
                RefreshCombobox();
            }

        }
        //Метод действия кнопки на удаление товара по ID 
        private void RemoveById_Click(object sender, RoutedEventArgs e)
        {
            StoreServiceClient client = new StoreServiceClient();

            if (ItemsComboBox != null)
            {
                try
                {
                    int id = ((ComputerStoreService.Data.Item)ItemsComboBox.SelectedItem).Id;
                    client.RemoveItemById(id);
                }
                catch (FaultException ex)
                {
                    MessageBox.Show("Что-то пошло не так! " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                finally
                {
                    client.Abort();
                    RefreshCombobox();
                }
            }
        }
        private void ViewAllItems_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AllItems(AutorId));
        }
        public void RefreshCombobox()
        {
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
                });
            }
            ItemsComboBox.ItemsSource = items;
            client.Abort();
        }
        //Метод для обновления списка совпадений 
        public async void RefreshSearchBar()
        {
            StoreServiceClient client = new StoreServiceClient();

            //Записываем в лист Itemы подходящие в критерий поиска

            var tempItems = await client.GetItmesLikeAsync(IdTextBox.Text);

            //Записываем их имена в отдельный лист

            List<String> names = new List<string>();
            foreach (var p in tempItems)
            {
                names.Add(p.Name);
            }
            client.Abort();

            // Передаем названия в список

            SearchBox.ItemsSource = names;
            
        }

        private void textChangedEventHandler(object sender, TextChangedEventArgs args)
        {
            RefreshSearchBar();
            SearchBox.IsDropDownOpen = true;
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IdTextBox.Text = (string)SearchBox.SelectedItem;
        }
    }
}
