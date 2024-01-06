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
            Position cryptoDetail = e.SelectedItem as Position;
            VM.GoToDetail(cryptoDetail);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Task.Run(async () => { await VM.LoadData(); }); ;
        }
    }
}
