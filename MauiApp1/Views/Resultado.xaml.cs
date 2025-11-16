namespace MauiApp1.Views;

public partial class Resultado : ContentPage
{
	public Resultado(Models.Calculo c)
	{
		InitializeComponent();
		BindingContext = c;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            DisplayAlert("Erro", ex.Message, "OK");
        }
    }
}