using MetalCutterCalculator.Models;

namespace MetalCutterCalculator.Services; 

public interface ICuttingCalculationService {
    OrderCalculation CalculateOrderByOrderParameters(OrderParameters orderParameters);
}