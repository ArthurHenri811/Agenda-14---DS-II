using Microsoft.Maui.Controls;

namespace HospedagemOnline;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnSobreAppClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SobrePage());
    }
}
