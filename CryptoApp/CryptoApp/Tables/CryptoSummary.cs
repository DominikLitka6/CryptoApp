using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApp.Tables
{
    public class CryptoSummary
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string ChangeColor { get; set; }
        public double AllPositionsProfit { get; set; }
        public double Volume { get; set; }
    }
}
