using CryptoApp.ViewModels;

namespace CryptoApp.Views;

public partial class CryptoListView : ContentPage
{
	CryptoListViewModel VM;
	public CryptoListView(CryptoListViewModel cryptoListViewModel)
	{
		InitializeComponent();
		BindingContext = VM = cryptoListViewModel;
	}

    protected override void OnAppearing()
    {
        VM.DownloadDataCommand.Execute(null);
        base.OnAppearing();
    }

}