using CryptoApp.DTO;

namespace CryptoApp.Services
{
    public interface ICryptoApiService
    {
        Task<List<CryptoData>> GetAllCryptoMapAsync();

    }
}
