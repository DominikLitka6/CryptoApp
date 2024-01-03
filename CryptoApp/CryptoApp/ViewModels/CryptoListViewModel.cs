using CryptoApp.Models;
using CryptoApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace CryptoApp.ViewModels
{
    public class CryptoListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        private readonly ICryptoApiService _cryptoApiService;

        public ObservableCollection<CryptoMap> Maps { get; set; } = new ObservableCollection<CryptoMap>();

        public CryptoListViewModel(ICryptoApiService cryptoApiService)
        {
            _cryptoApiService = cryptoApiService;
            var maps = _cryptoApiService.GetAllCryptoMap();
          
            foreach (var item in maps)
            {
                Maps.Add(item);
            }

        }
    }
}
