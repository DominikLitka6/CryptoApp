using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApp.Models
{
    public class CryptoMap
    {
        public int Id { get; set; }
        public int Rank { get; set; }
        public required string Name { get; set; } 
        public required string Symbol { get; set; }
          
    }
}
