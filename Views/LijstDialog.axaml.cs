using Avalonia.Controls;
using Avalonia.Interactivity;
using QuadroApp.Model.DB;

namespace QuadroApp.Views;

public partial class LijstDialog : Window
{
    private readonly TypeLijst _editCopy;

    public TypeLijst? Result { get; private set; }

    public LijstDialog()
    {
        InitializeComponent();
        _editCopy = new TypeLijst();
        DataContext = _editCopy;
    }

    public LijstDialog(TypeLijst lijst) : this()
    {
        _editCopy.Id = lijst.Id;
        _editCopy.Artikelnummer = lijst.Artikelnummer;
        _editCopy.Levcode = lijst.Levcode;
                _editCopy.BreedteCm = lijst.BreedteCm;
        _editCopy.PrijsPerMeter = lijst.PrijsPerMeter;
        _editCopy.VasteKost = lijst.VasteKost;
        _editCopy.WerkMinuten = lijst.WerkMinuten;
        _editCopy.LeverancierId = lijst.LeverancierId;
                _editCopy.Leverancier = lijst.Leverancier;
        _editCopy.Serie = lijst.Serie;
        _editCopy.VoorraadMeter = lijst.VoorraadMeter;
        _editCopy.InventarisKost = lijst.InventarisKost;

        DataContext = _editCopy;
    }

    private void Annuleer_Click(object? sender, RoutedEventArgs e)
    {
        Result = null;
        Close(null);
    }

    private void Opslaan_Click(object? sender, RoutedEventArgs e)
    {
        Result = _editCopy;
        Close(Result);
    }
}
