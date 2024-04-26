namespace jgarridoExamen;

public partial class ResumenPage : ContentPage
{
    public string Username { get; set; }
    public ResumenPage(string username)
	{
		InitializeComponent();
        UsernameLabel.Text = $"Usuario conectado: {username}";
    }

    public ResumenPage()
    {
    }
}