using CryptoApp.Services;
using CryptoApp.Tables;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApp.ViewModels
{

    public class CryptoDetailsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(storage, value))
                return false;

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        private readonly ICryptoApiService _cryptoApiService;
        private readonly IDatabaseService _databaseService;

        public ObservableCollection<Position> Positions { get; private set; }
        public CryptoDetailsViewModel(IDatabaseService databaseService, ICryptoApiService cryptoApiService)
        {
            Positions = new ObservableCollection<Position>();
            _cryptoApiService = cryptoApiService;
            _databaseService = databaseService;
        }

        private bool _isBusy;
        public bool IsBusy
        {
            set { SetProperty(ref _isBusy, value); }
            get { return _isBusy; }
        }
        
        private Position _cryptoInfo;
        public Position CryptoInfo
        {
            set { SetProperty(ref _cryptoInfo, value); }
            get { return _cryptoInfo; }
        }

        public async Task LoadData(string cryptoSymbol)
        {
            var positions = await _databaseService.GetPositions(cryptoSymbol);
            CryptoInfo = positions.FirstOrDefault();

            foreach (var item in positions)
            {
                Positions.Add(item);
            }
        }
    }
}
