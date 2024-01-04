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

        private readonly string arrowUp = "▲";
        private readonly string arrowDown = "▼";
        private readonly string colorCryptoGreen = "#03C03C";
        private readonly string colorCryptoRed = "#FF0800";

        public List<CryptoDetail> GetCryptoDetails()
        {
            var res = new List<CryptoDetail>
            {
                new()
                {
                    Image = $"https://assets.coincap.io/assets/icons/{"btc"}@2x.png",
                    Name = "Bitcoin",
                    Symbol = "BTC",
                    Id = 1,
                    Rank = 1,
                    DailyChange = 2.73d,
                    Profit = -22.12,
                    OverallProfitColor = colorCryptoRed,
                    DailyChangeColor = colorCryptoGreen,
                    ArrowSymbol = arrowUp

                },
                new()
                {
                    Image = $"https://assets.coincap.io/assets/icons/{"sol"}@2x.png",
                    Name = "Solana",
                    Symbol = "SOL",
                    Id = 2,
                    Rank = 2,
                    DailyChange = 4.26d,
                    Profit = 168.55d,
                    OverallProfitColor = colorCryptoGreen,
                    DailyChangeColor = colorCryptoGreen,
                    ArrowSymbol = arrowUp
                },
                new()
                {
                    Image = $"https://assets.coincap.io/assets/icons/{"dot"}@2x.png",
                    Name = "Polkadot",
                    Symbol = "DOT",
                    Id = 3,
                    Rank = 3,
                    DailyChange = 2.15d,
                    Profit = -28.60d,
                    DailyChangeColor = colorCryptoGreen,
                    OverallProfitColor = colorCryptoRed,
                    ArrowSymbol = arrowUp
                },
                new()
                {
                     Image = $"https://assets.coincap.io/assets/icons/{"ftm"}@2x.png",
                    Name = "Fantom",
                    Symbol = "FTM",
                    Id = 4,
                    Rank = 4,
                    DailyChange = 1.87d,
                    Profit = -22.51d,
                    DailyChangeColor = colorCryptoGreen,
                    OverallProfitColor = colorCryptoRed,
                    ArrowSymbol = arrowUp
                },
                new()
                {
                    Image = $"https://assets.coincap.io/assets/icons/{"avax"}@2x.png",
                    Name = "Avalanche",
                    Symbol = "AVAX",
                    Id = 5,
                    Rank = 5,
                    DailyChange = 3.69d,
                    Profit = -133.74d,
                    DailyChangeColor = colorCryptoGreen,
                    OverallProfitColor = colorCryptoRed,
                    ArrowSymbol = arrowUp
                }
            };

            return res;
        }
    }
}
