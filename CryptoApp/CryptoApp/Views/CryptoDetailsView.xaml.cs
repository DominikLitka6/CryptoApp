using CryptoApp.ViewModels;

namespace CryptoApp.Views;

[QueryProperty(nameof(CryptoSymbol), "CryptoSymbol")]
public partial class CryptoDetailsView: ContentPage
{
	private CryptoDetailsViewModel VM;

    public string CryptoSymbol
    {
        set
        {
            Task.Run(async () => { await VM.LoadData(value); });
        }
    }
    public CryptoDetailsView(CryptoDetailsViewModel cryptoDetailsViewModel)
	{
		InitializeComponent();
		BindingContext = VM = cryptoDetailsViewModel;
	}
}