using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApp.Tables
{
    public class CryptoDetail
    {
        public int Id { get; set; }
        public int Rank { get; set; }
        public required string Name { get; set; }
        public required string Symbol { get; set; }
        public required string Image { get; set; }
        public double Profit { get; set; }
        public double DailyChange { get; set; }
        public required string DailyChangeColor { get; set; }
        public required string OverallProfitColor { get; set; }
        public required string ArrowSymbol { get; set; }
    }
}
