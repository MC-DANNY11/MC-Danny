namespace MC_Danny.Views
{
    public partial class MainFlyoutPage : FlyoutPage
    {
        public MainFlyoutPage()
        {
            InitializeComponent();
        }

        // Navegar a la p�gina de Inicio
        private void OnInicioClicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new V_Inicio());
            IsPresented = false; // Cierra el men� hamburguesa
        }

        // Navegar a la p�gina de Ropa
        private void OnRopaClicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new V_Ropa());
            IsPresented = false;
        }

        // Navegar a la p�gina de Carrito
        private void OnCarritoClicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new V_Carrito());
            IsPresented = false;
        }

        // Navegar a la p�gina de Zapatos
        private void OnZapatosClicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new V_Zapato());
            IsPresented = false;
        }

        // Navegar a la p�gina de Reloj
        private void OnRelojClicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new V_Reloj());
            IsPresented = false;
        }
    }
}
