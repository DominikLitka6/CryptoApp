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

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);
		VM.DownloadDataCommand.Execute(null);
    }
}