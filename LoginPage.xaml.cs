namespace MC_Danny;
using MC_Danny.Views;
using CommunityToolkit.Maui;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        // Aqu� ir�a tu l�gica de validaci�n del usuario
        if (username == "admin" && password == "1234")
        {
            // Navegar a la p�gina principal despu�s del login exitoso
            Limpiar();
            Application.Current.MainPage = new AppShell();
        }
        else
        {
            // Utiliza DisplayAlert para mostrar un mensaje de error
            Limpiar();
            await this.DisplayAlert("Error", "Credenciales Incorrectas", "Ok");
        }
    }
    public void Limpiar()
    {
        UsernameEntry.Text = "";
        PasswordEntry.Text = "";
    }

}