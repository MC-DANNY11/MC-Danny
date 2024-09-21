using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;

namespace MC_Danny.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Animar la entrada del menú desde el lado izquierdo
            await MenuContainer.TranslateTo(0, 0, 250, Easing.CubicInOut);
        }

        protected override async void OnDisappearing()
        {
            base.OnDisappearing();

            // Animar la salida del menú hacia el lado izquierdo
            await MenuContainer.TranslateTo(-MenuContainer.Width, 0, 250, Easing.CubicInOut);
        }

        private async void btncerrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
