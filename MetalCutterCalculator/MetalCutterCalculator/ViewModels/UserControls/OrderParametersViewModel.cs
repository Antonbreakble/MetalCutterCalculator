using CommunityToolkit.Mvvm.ComponentModel;
using MetalCutterCalculator.Models;
using Metsys.Bson;


namespace MetalCutterCalculator.ViewModels.UserControls; 

public partial class  OrderParametersViewModel : ObservableObject {
    [ObservableProperty] private double _metalLenght;
    [ObservableProperty] private double _metalWidth;
    [ObservableProperty] private double _metalThickness;
    [ObservableProperty] private uint _detailsNumber;
    [ObservableProperty] private double _cuttingLength;
    [ObservableProperty] private uint _metalInserts;
    [ObservableProperty] private uint _metalBends;

    public OrderParameters GetOrderParameters() {
        return new() {
            DetailsNumber = _detailsNumber,
            CuttingLength = _cuttingLength,
            MetalBends = _metalBends,
            Thickness = _metalThickness,
            MetalInserts = _metalInserts,
            Lenght = _metalLenght,
            Width = _metalWidth
        };
    }
}