using CryptoApp.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApp.Services
{
    public class DatabaseService : IDatabaseService
    {
        SQLiteAsyncConnection Database;

        private readonly string arrowUp = "▲";
        private readonly string arrowDown = "▼";
        private readonly string colorCryptoGreen = "#03C03C";
        private readonly string colorCryptoRed = "#FF0800";

        async Task Init()
        {
            if (Database is not null)
                return;

            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            var result = await Database.CreateTableAsync<Position>();
            if (result == CreateTableResult.Created)
            {
                CreateDemoPosition();
            }
        }

        private void CreateDemoPosition()
        {
            var res = new List<Position>
            {
                new()
                {
                    Image = $"https://assets.coincap.io/assets/icons/{"btc"}@2x.png",
                    Name = "Bitcoin",
                    Symbol = "BTC",
                    Rank = 1,
                    Profit = 3.16,
                    OverallProfitColor = colorCryptoGreen,
                    DailyChangeColor = colorCryptoGreen,
                    ArrowSymbol = arrowUp,
                    CryptoChangeDay = -4.3d,
                    CryptoChangeWeek = -2.2d,
                    CryptoChangeMonth = -8.5d,
                    CryptoChangeYear = 81.1d,
                    CryptoChangeDayColor = colorCryptoRed,
                    CryptoChangeMonthColor = colorCryptoRed,
                    CryptoChangeWeekColor = colorCryptoRed,
                    CryptoChangeYearColor = colorCryptoGreen,
                    CryptoChangeDayArrow = arrowDown,
                    CryptoChangeMonthArrow = arrowDown,
                    CryptoChangeWeekArrow = arrowDown,
                    CryptoChangeYearArrow = arrowUp,
                    Volume = 0.01d,
                    CryptoBuyPrice = 42926.55d,
                    BuyDate = new DateTime(2023, 12, 15),
                    ProfitPercent = 0.43d,
                    MoneySpend = 843.22d
                },
                new()
                {
                    Image = $"https://assets.coincap.io/assets/icons/{"btc"}@2x.png",
                    Name = "Bitcoin",
                    Symbol = "BTC",
                    Rank = 1,
                    Profit = -25.90,
                    OverallProfitColor = colorCryptoRed,
                    DailyChangeColor = colorCryptoGreen,
                    ArrowSymbol = arrowUp,
                    CryptoChangeDay = -4.3d,
                    CryptoChangeWeek = -2.2d,
                    CryptoChangeMonth = -8.5d,
                    CryptoChangeYear = 81.1d,
                    CryptoChangeDayColor = colorCryptoRed,
                    CryptoChangeMonthColor = colorCryptoRed,
                    CryptoChangeWeekColor = colorCryptoRed,
                    CryptoChangeYearColor = colorCryptoGreen,
                    CryptoChangeDayArrow = arrowDown,
                    CryptoChangeMonthArrow = arrowDown,
                    CryptoChangeWeekArrow = arrowDown,
                    CryptoChangeYearArrow = arrowUp,
                    Volume = 0.01d,
                    CryptoBuyPrice = 43966.00d,
                    BuyDate = new DateTime(2023, 12, 21),
                    ProfitPercent = -3.29d,
                    MoneySpend = 868.38d 
                },
                new()
                {
                    Image = $"https://assets.coincap.io/assets/icons/{"sol"}@2x.png",
                    Name = "Solana",
                    Symbol = "SOL",
                    Rank = 2,
                    Profit = 168.55d,
                    OverallProfitColor = colorCryptoGreen,
                    DailyChangeColor = colorCryptoGreen,
                    ArrowSymbol = arrowUp,
                    CryptoChangeDay = -4.3d,
                    CryptoChangeWeek = -2.2d,
                    CryptoChangeMonth = -8.5d,
                    CryptoChangeYear = 81.1d,
                    CryptoChangeDayColor = colorCryptoRed,
                    CryptoChangeMonthColor = colorCryptoRed,
                    CryptoChangeWeekColor = colorCryptoRed,
                    CryptoChangeYearColor = colorCryptoGreen,
                    CryptoChangeDayArrow = arrowDown,
                    CryptoChangeMonthArrow = arrowDown,
                    CryptoChangeWeekArrow = arrowDown,
                    CryptoChangeYearArrow = arrowUp
                },
                new()
                {
                    Image = $"https://assets.coincap.io/assets/icons/{"dot"}@2x.png",
                    Name = "Polkadot",
                    Symbol = "DOT",
                    Rank = 3,
                    Profit = -28.60d,
                    DailyChangeColor = colorCryptoGreen,
                    OverallProfitColor = colorCryptoRed,
                    ArrowSymbol = arrowUp,
                    CryptoChangeDay = -4.3d,
                    CryptoChangeWeek = -2.2d,
                    CryptoChangeMonth = -8.5d,
                    CryptoChangeYear = 81.1d,
                    CryptoChangeDayColor = colorCryptoRed,
                    CryptoChangeMonthColor = colorCryptoRed,
                    CryptoChangeWeekColor = colorCryptoRed,
                    CryptoChangeYearColor = colorCryptoGreen,
                    CryptoChangeDayArrow = arrowDown,
                    CryptoChangeMonthArrow = arrowDown,
                    CryptoChangeWeekArrow = arrowDown,
                    CryptoChangeYearArrow = arrowUp

                },
                new()
                {
                    Image = $"https://assets.coincap.io/assets/icons/{"ftm"}@2x.png",
                    Name = "Fantom",
                    Symbol = "FTM",
                    Rank = 4,
                    Profit = -22.51d,
                    DailyChangeColor = colorCryptoGreen,
                    OverallProfitColor = colorCryptoRed,
                    ArrowSymbol = arrowUp,
                    CryptoChangeDay = -4.3d,
                    CryptoChangeWeek = -2.2d,
                    CryptoChangeMonth = -8.5d,
                    CryptoChangeYear = 81.1d,
                    CryptoChangeDayColor = colorCryptoRed,
                    CryptoChangeMonthColor = colorCryptoRed,
                    CryptoChangeWeekColor = colorCryptoRed,
                    CryptoChangeYearColor = colorCryptoGreen,
                    CryptoChangeDayArrow = arrowDown,
                    CryptoChangeMonthArrow = arrowDown,
                    CryptoChangeWeekArrow = arrowDown,
                    CryptoChangeYearArrow = arrowUp
                },
                new()
                {
                    Image = $"https://assets.coincap.io/assets/icons/{"avax"}@2x.png",
                    Name = "Avalanche",
                    Symbol = "AVAX",
                    Rank = 5,
                    Profit = -133.74d,
                    DailyChangeColor = colorCryptoGreen,
                    OverallProfitColor = colorCryptoRed,
                    ArrowSymbol = arrowUp,
                    CryptoChangeDay = -4.3d,
                    CryptoChangeWeek = -2.2d,
                    CryptoChangeMonth = -8.5d,
                    CryptoChangeYear = 81.1d,
                    CryptoChangeDayColor = colorCryptoRed,
                    CryptoChangeMonthColor = colorCryptoRed,
                    CryptoChangeWeekColor = colorCryptoRed,
                    CryptoChangeYearColor = colorCryptoGreen,
                }
            };

            Database.InsertAllAsync(res);

        }

        public async Task<List<Position>> GetPositions()
        {
            await Init();

            var result = await Database.Table<Position>().ToListAsync();
            return result;
        }
        public async Task<List<Position>> GetPositions(string symbol)
        {
            await Init();

            var result = await Database.Table<Position>().ToListAsync();
            return result.Where(x => x.Symbol == symbol).ToList();
        }


    }
}
