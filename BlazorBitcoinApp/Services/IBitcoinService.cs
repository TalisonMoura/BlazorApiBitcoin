using BlazorBitcoinApp.Dtos;

namespace BlazorBitcoinApp.Services
{
    public interface IBitcoinService
    {
        Task<List<BitcoinDataDTO>> FindByDate(DateTime startDate);
    }
}
