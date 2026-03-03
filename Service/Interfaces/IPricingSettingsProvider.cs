using System.Threading.Tasks;

namespace QuadroApp.Service.Interfaces;

public interface IPricingSettingsProvider
{
    Task<decimal> GetUurloonAsync();
    Task<decimal> GetBtwPercentAsync();
    Task<decimal> GetStaaflijstWinstFactorAsync();
    Task<decimal> GetStaaflijstAfvalPercentageAsync();
    Task<decimal> GetDefaultWinstFactorAsync();
    Task<decimal> GetDefaultAfvalPercentageAsync();
    Task SaveStaaflijstWinstFactorAsync(decimal value);
    Task SaveStaaflijstAfvalPercentageAsync(decimal value);
    Task SaveDefaultWinstFactorAsync(decimal value);
    Task SaveDefaultAfvalPercentageAsync(decimal value);
}
