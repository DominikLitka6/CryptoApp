using CryptoApp.Tables;
using CryptoApp.ViewModels;

namespace CryptoApp.Views
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel VM;
        public MainPage(MainPageViewModel mainPageViewModel)
        {
            InitializeComponent();

            BindingContext = VM = mainPageViewModel;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            CryptoSummary cryptoDetail = e.SelectedItem as CryptoSummary;
            VM.GoToDetail(cryptoDetail);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Task.Run(async () => { await VM.LoadData(); }); ;
        }
    }
}
