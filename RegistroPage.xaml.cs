namespace jgarridoExamen;

public partial class RegistroPage : ContentPage
{
    public string Username { get; set; }
    public RegistroPage(string username)
	{
		InitializeComponent();
        UsernameLabel.Text = $"Usuario conectado: {username}";
    }


    private const decimal Monto = 1500;
    
    

    private decimal CalcularMontoInscripcion()
    {
        decimal MontoInicial = int.Parse(montoInicialEntry.Text);
        decimal MontoRestante = Monto - MontoInicial;
        decimal MontoRegistrado = MontoRestante * 0.25m;
        return MontoRegistrado;
    }

    private decimal CalcularMontoMensual()
    {
        decimal MontoInicial = int.Parse(montoInicialEntry.Text);
        decimal MontoRestante = Monto - MontoInicial;
        decimal MontoMensual = MontoRestante * 0.25m * 1.04m;
        return MontoMensual;
    }
    private async void CalcularPagoButton_Clicked(object sender, EventArgs e)
    {
        
        decimal montoinscripcion = CalcularMontoInscripcion();
        decimal montomensual = CalcularMontoMensual();
        await DisplayAlert("Resultados", $"Monto de inscripción: {montoinscripcion:C}\nPago mensual: {montomensual:C}", "OK");
        pagoMensualEntry.Text = $"{montomensual:C}";
    }

    private async void VerResumenButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ResumenPage());
    }
}