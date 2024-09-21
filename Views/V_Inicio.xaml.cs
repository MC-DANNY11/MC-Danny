using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Android.App;
using Android.OS;
using Android.Views;

namespace MC_Danny.Views
{
    public partial class V_Inicio : ContentPage
    {
        public V_Inicio()
        {
            InitializeComponent();
            ApplyStatusBarColor();
        }

        private void ApplyStatusBarColor()
        {
            if (DeviceInfo.Platform == DevicePlatform.Android)
            {
                // Obtener la actividad actual desde el contexto
                var activity = Platform.CurrentActivity;
                if (activity != null)
                {
                    // Cambiar el color de la barra de estado
                    activity.Window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#FFFFFF")); // Cambia a tu color deseado
                    activity.Window.DecorView.SystemUiVisibility = (StatusBarVisibility)SystemUiFlags.LightStatusBar;
                }
            }
        }

        private async void OnMenuClicked(object sender, EventArgs e)
        {
            // Abrir un menú lateral manualmente
            await Navigation.PushModalAsync(new MenuPage());
        }
    }
}
