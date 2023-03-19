using CommunityToolkit.Mvvm.ComponentModel;
using MetalCutterCalculator.Models;
using Metsys.Bson;


namespace MetalCutterCalculator.ViewModels.UserControls; 

public partial class  OrderParametersViewModel : ObservableObject {
    [ObservableProperty] private uint _metalLenght;
    [ObservableProperty] private uint _metalWidth;
    [ObservableProperty] private uint _metalThickness;
    [ObservableProperty] private uint _detailsNumber;
    [ObservableProperty] private double _cuttingLength;
    [ObservableProperty] private uint _metalInserts;
    [ObservableProperty] private uint _metalBends;

    public OrderParameters GetOrderParameters() {
        return new() {
            DetailsNumber = DetailsNumber,
            CuttingLength = CuttingLength,
            MetalBends = MetalBends,
            Thickness = MetalThickness,
            MetalInserts = MetalInserts,
            Lenght = MetalLenght,
            Width = MetalWidth
        };
    }
}