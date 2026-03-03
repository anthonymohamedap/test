using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuadroApp.Service.Interfaces;
using System.Threading.Tasks;

namespace QuadroApp.ViewModels;

public partial class InstellingenViewModel : ObservableObject
{
    private readonly IPricingSettingsProvider _pricingSettingsProvider;
    private readonly IToastService _toast;

    [ObservableProperty] private decimal staaflijstWinstFactor;
    [ObservableProperty] private decimal staaflijstAfvalPercentage;
    [ObservableProperty] private decimal defaultWinstFactor;
    [ObservableProperty] private decimal defaultAfvalPercentage;

    public InstellingenViewModel(IPricingSettingsProvider pricingSettingsProvider, IToastService toast)
    {
        _pricingSettingsProvider = pricingSettingsProvider;
        _toast = toast;
    }

    public async Task InitializeAsync()
    {
        StaaflijstWinstFactor = await _pricingSettingsProvider.GetStaaflijstWinstFactorAsync();
        StaaflijstAfvalPercentage = await _pricingSettingsProvider.GetStaaflijstAfvalPercentageAsync();
        DefaultWinstFactor = await _pricingSettingsProvider.GetDefaultWinstFactorAsync();
        DefaultAfvalPercentage = await _pricingSettingsProvider.GetDefaultAfvalPercentageAsync();
    }

    [RelayCommand]
    private async Task SaveAsync()
    {
        await _pricingSettingsProvider.SaveStaaflijstWinstFactorAsync(StaaflijstWinstFactor);
        await _pricingSettingsProvider.SaveStaaflijstAfvalPercentageAsync(StaaflijstAfvalPercentage);
        await _pricingSettingsProvider.SaveDefaultWinstFactorAsync(DefaultWinstFactor);
        await _pricingSettingsProvider.SaveDefaultAfvalPercentageAsync(DefaultAfvalPercentage);
        _toast.Success("Instellingen opgeslagen.");
    }
}
