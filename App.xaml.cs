using MC_Danny.Views;

namespace MC_Danny
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
            //MainPage = new NavigationPage(new LoginPage());
        }
        // Método para cambiar a la página principal con el menú hamburguesa después del login
        public void NavigateToMainPage()
        {
            MainPage = new MainFlyoutPage();
        }
    }
}
