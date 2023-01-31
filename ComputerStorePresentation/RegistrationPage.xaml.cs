using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ComputerStoreService;
using System.ServiceModel;
using StoreServiceReference;

namespace ComputerStorePresentation
{
    /// <summary>
    /// Interaction logic for RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }
        //Кнопка "Назад"
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginPage());
        }
        //Кнопка "Регистрация"
        private void RegButton_Click(Object sender, RoutedEventArgs e)
        {
            
            var name = NameTextBox.Text;
            var email = EmailTextBox.Text;
            var pass = PassTextBox.Text;
            try {

                StoreServiceClient client = new StoreServiceClient();
                bool temp = false;

                temp = client.Registration(name, email, pass);


                NameTextBox.Text = "";
                EmailTextBox.Text = "";
                PassTextBox.Text = "";


                client.Abort();


                if (temp)
                  NavigationService.Navigate(new LoginPage());
                
            } catch(FaultException ex) 
            {
                MessageBox.Show("Что-то пошло не так! " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            } 
            

            

        }
    }
}

