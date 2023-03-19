using CommunityToolkit.Mvvm.ComponentModel;
using MetalCutterCalculator.Models;

namespace MetalCutterCalculator.ViewModels.UserControls; 

public partial class OrderCalculationViewModel : ObservableObject {
    [ObservableProperty] private double _square;
    [ObservableProperty] private double _mass;
    [ObservableProperty] private double _metalCost;
    [ObservableProperty] private double _cuttingCost;
    [ObservableProperty] private double _metalInsertsCost;
    [ObservableProperty] private double _bendingCost;
    [ObservableProperty] private double _costWithInnerMetal;
    [ObservableProperty] private double _costWithOuterMetal;

    public void CalculationUpdate(OrderCalculation orderCalculation) {
        Square = orderCalculation.Square;
        Mass = orderCalculation.Mass;
        MetalCost = orderCalculation.MetalCost;
        CuttingCost = orderCalculation.CuttingCost;
        MetalInsertsCost = orderCalculation.MetalInsertsCost;
        BendingCost = orderCalculation.BendingCost;
        CostWithInnerMetal = orderCalculation.CostWithInnerMetal;
        CostWithOuterMetal = orderCalculation.CostWithOuterMetal;
    }
}