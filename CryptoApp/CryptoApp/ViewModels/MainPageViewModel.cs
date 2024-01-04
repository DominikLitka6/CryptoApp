using CryptoApp.Services;
using CryptoApp.Views;
using System;
using System.Collections.Generic;
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

        public MainPageViewModel(IDatabaseService databaseService, ICryptoApiService cryptoApiService)
        {
            _databaseService = databaseService;
            _cryptoApiService = cryptoApiService;

            AddNewCrypto = new Command(() => { Shell.Current.GoToAsync(nameof(CryptoListView)); });
        }


    }
}
