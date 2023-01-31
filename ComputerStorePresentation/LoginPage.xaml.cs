using StoreServiceReference;
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
using ComputerStoreService;
using System.ServiceModel;

namespace ComputerStorePresentation
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        //Мето выполняющийся по нажатию кнопки Login. Используется метод Login из сервиса
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var email = LoginTextbox.Text;
            var password = PassTextbox.Password.ToString();
            StoreServiceClient client = new StoreServiceClient();
            try
            {
                int temp = client.Login(email, password);

                if (temp != 0)
                {
                    NavigationService.Navigate(new StorePage(temp));
                    client.Abort();
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

            private void RegistrationButton_Click(object sender, RoutedEventArgs e)
            {
                NavigationService.Navigate(new RegistrationPage());
            }
        }
    }
