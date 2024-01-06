using CryptoApp.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApp.Services
{
    public interface IDatabaseService
    {
        Task<List<Position>> GetPositions();
        Task<List<Position>> GetPositions(string symbol);
    }
}
