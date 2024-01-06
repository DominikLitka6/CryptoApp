using CryptoApp.DTO;
using CryptoApp.Services;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Xml.Linq;

namespace CryptoApp.ViewModels
{
    public class CryptoListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        private readonly ICryptoApiService _cryptoApiService;
        public ICommand DownloadDataCommand { get; private set; }
       
        private bool _isBusy;
        public bool IsBusy
        {
            set { SetProperty(ref _isBusy, value); }
            get { return _isBusy; }
        }

        bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(storage, value))
                return false;

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        public ObservableCollection<CryptoData> Maps { get; set; } = new ObservableCollection<CryptoData>();

        public CryptoListViewModel(ICryptoApiService cryptoApiService)
        {
            _cryptoApiService = cryptoApiService;

            DownloadDataCommand = new Command(DownloadData);
        }

       

        private void DownloadData()
        {
            IsBusy = true;

            Task.Run(async () =>
            {
                var data = await _cryptoApiService.GetAllCryptoMapAsync();
                foreach (var item in data)
                {
                    item.image = $"https://assets.coincap.io/assets/icons/{item.symbol.ToLower()}@2x.png";
                    Maps.Add(item);
                }
                IsBusy = false;
            });

        }
    }
}
