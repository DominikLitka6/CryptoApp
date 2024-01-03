using CryptoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApp.Services
{
    public class CryptoApiService : ICryptoApiService
    {
        public List<CryptoMap> GetAllCryptoMap()
        {
            var cryptoMap = new CryptoMap() { Name = "Bitcoin", Symbol = "BTC", Id = 1, Rank = 1 };

            var result = new List<CryptoMap>
            {
                cryptoMap
            };

            return result;
                   
        }
    }
}
