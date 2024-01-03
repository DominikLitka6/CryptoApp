using CryptoApp.ViewModels;

namespace CryptoApp.Views;

public partial class CryptoListView : ContentPage
{
	public CryptoListView(CryptoListViewModel cryptoListViewModel)
	{
		InitializeComponent();
		BindingContext = cryptoListViewModel;
	}
}