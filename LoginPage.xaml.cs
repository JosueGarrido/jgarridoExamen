namespace jgarridoExamen;

public partial class LoginPage : ContentPage
{
    private Dictionary<string, string> users = new Dictionary<string, string>()
        {
            {"estudiante2024", "uisrael2024"},
            {"examen1", "parcial1"}
        };

    public LoginPage()
	{
		InitializeComponent();
	}

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        string username = usernameEntry.Text;
        string password = passwordEntry.Text;

        if (users.ContainsKey(username) && users[username] == password)
        {
            await Navigation.PushAsync(new RegistroPage(username));
        }
        else
        {
            await DisplayAlert("Error", "Datos incorrectos", "OK");
        }
    }
}