using SQLite;

namespace CryptoApp.Tables
{
    [SQLite.Table(nameof(Position))]
    public class Position
    {
        [PrimaryKey, AutoIncrement]
        public int PositionID { get; set; }

        //cryptocurrency info
        public string Symbol { get; set; }
        public int Rank { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    
        public double CryptoChangeDay { get; set; }
        public string CryptoChangeDayArrow { get; set; }
        public string CryptoChangeDayColor { get; set; }
        public double CryptoChangeWeek { get; set; }
        public string CryptoChangeWeekArrow { get; set; }
        public string CryptoChangeWeekColor { get; set; }
        public double CryptoChangeMonth { get; set; }
        public string CryptoChangeMonthArrow { get; set; }
        public string CryptoChangeMonthColor { get; set; }
        public double CryptoChangeYear { get; set; }
        public string CryptoChangeYearArrow { get; set; }
        public string CryptoChangeYearColor { get; set; }



        //position info
        public double Profit { get; set; }
        public double ProfitPercent { get; set; }
        public string DailyChangeColor { get; set; }
        public string OverallProfitColor { get; set; }
        public string ArrowSymbol { get; set; }
        public double Volume { get; set; }
        public double CryptoBuyPrice { get; set; }
        public DateTime BuyDate { get; set; }
        public double MoneySpend { get; set; }


    }
}
