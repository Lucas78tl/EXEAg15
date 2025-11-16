using MauiApp1.Models;

namespace MauiApp1.Views;

public partial class index : ContentPage
{
    App PropriedadesApp;
    public index()
	{
		InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        DataCheckin.MinimumDate = DateTime.Today;
        DataCheckin.MaximumDate = DateTime.Today.AddMonths(1);

        DataCheckout.MinimumDate = DateTime.Today.AddDays(1);
        DataCheckout.MaximumDate = DateTime.Today.AddMonths(6);

    }

    private void DataCheckin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DataCheckout.MinimumDate = ((DateTime)elemento.Date).AddDays(1);
        DataCheckout.MaximumDate = ((DateTime)elemento.Date).AddMonths(6);
    }

    private void DataCheckout_DateSelected(object sender, DateChangedEventArgs e)
    {

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {

            Calculo c = new Calculo(){
                ELEvento = (ELE.Text),
                ENE = (ENEvento.Text),
                ENP = int.Parse(ENP.Text),
                ECP = double.Parse(ECP.Text),
                DataCheckin = (DateTime)DataCheckin.Date,
                DataCheckout = (DateTime)DataCheckout.Date,
            };

            await Navigation.PushAsync(new Resultado(c));

        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "OK");
        }
    }
}