using CryptoApp.Services;
using CryptoApp.Tables;
using CryptoApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptoApp.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private readonly ICryptoApiService _cryptoApiService;
        private readonly IDatabaseService _databaseService;

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public ICommand AddNewCrypto { get; private set; }

        public ObservableCollection<CryptoSummary> CryptoList { get; private set; }

        public MainPageViewModel(IDatabaseService databaseService, ICryptoApiService cryptoApiService)
        {
            _databaseService = databaseService;
            _cryptoApiService = cryptoApiService;
            CryptoList = new ObservableCollection<CryptoSummary>();

            AddNewCrypto = new Command(() => { Shell.Current.GoToAsync(nameof(CryptoListView)); });
        }

        public async Task LoadData()
        {
            var cryptoDetails = await _databaseService.GetCryptoSummary();
            foreach (var item in cryptoDetails)
            {
                CryptoList.Add(item);
            }
        }

        public async Task<double> GetTotalProfitForCrypto(string symbol)
        {
            var cryptoDetails = await _databaseService.GetPositions(symbol);

            return cryptoDetails.Sum(x => x.Profit);
        }

        public void GoToDetail(CryptoSummary detail)
        {
            var navigationParameter = new Dictionary<string, object> { { "CryptoSymbol", detail.Symbol } };
            Shell.Current.GoToAsync((nameof(CryptoDetailsView)), parameters: navigationParameter) ;
        }
    }
}
