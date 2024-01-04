using CryptoApp.DTO;
using CryptoApp.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace CryptoApp.ViewModels
{
    public class CryptoListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        private readonly ICryptoApiService _cryptoApiService;
        public ICommand DownloadDataCommand { get; private set; }

        public ObservableCollection<CryptoData> Maps { get; set; } = new ObservableCollection<CryptoData>();

        public CryptoListViewModel(ICryptoApiService cryptoApiService)
        {
            _cryptoApiService = cryptoApiService;

            DownloadDataCommand = new Command(() => DownloadData());
          
        }

        private void DownloadData()
        {
            Task.Run(async () =>
            {
                var data = await _cryptoApiService.GetAllCryptoMapAsync();

                for (int i = 0; i < 100; i++)
                {
                    Maps.Add(data[i]);
                }
            });

        }
    }
}
