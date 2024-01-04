using CryptoApp.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApp.Services
{
    public class DatabaseService : IDatabaseService
    {
        public List<CryptoDetail> GetCryptoDetails()
        {
            var res = new List<CryptoDetail>
            {
                new()
                {
                    Image = "https://en.wikipedia.org/wiki/Bitcoin#/media/File:Bitcoin.svg",
                    Name = "Bitcoin",
                    Symbol = "BTC",
                    Id = 1,
                    Rank = 1
                },
                new()
                {
                    Image = "https://en.wikipedia.org/wiki/Solana_%28blockchain_platform%29#/media/File:Solana_logo.png",
                    Name = "Solana",
                    Symbol = "Sol",
                    Id = 2,
                    Rank = 4
                }
            };

            return res;
        }
    }
}
