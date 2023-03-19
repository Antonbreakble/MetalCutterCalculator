using System;
using MetalCutterCalculator.Models;

namespace MetalCutterCalculator.Services; 

public class CuttingCalculationService : ICuttingCalculationService {
    private const double MagicNumber = 0.0000078;
    private readonly int[] _priceListForShort;
    private readonly int[] _priceListForLong;
    private readonly int[] _list;

    public CuttingCalculationService() {
        _priceListForLong = new[] {20, 28, 43, 50, 58, 68, 84, 125, 144, 186, 298, 432};
        _priceListForShort = new[] {27, 36, 57, 64, 76, 87, 111, 154, 191, 224, 360, 519};
        _list = new[] {1, 2, 3, 4, 5, 6, 8, 10, 12, 14, 16, 20};
    }

    public OrderCalculation CalculateOrderByOrderParameters(OrderParameters orderParameters) {
        return new OrderCalculation {
            Square = GetSquare(orderParameters),
            Mass = GetMass(orderParameters),
            MetalCost = GetMetalCost(orderParameters),
            CuttingCost = GetCuttingCost(orderParameters),
            MetalInsertsCost = GetMetalInsertsCost(orderParameters),
            BendingCost = GetBendingCost(orderParameters),
            CostWithInnerMetal = GetCostWithInnerMetal(orderParameters),
            CostWithOuterMetal = GetCostWithOuterMetal(orderParameters),
        };
    }

    private double GetCostWithInnerMetal(OrderParameters orderParameters) {
        return GetMetalCost(orderParameters) + GetCuttingCost(orderParameters) + GetBendingCost(orderParameters) +
               GetMetalInsertsCost(orderParameters);
    }
    private double GetCostWithOuterMetal(OrderParameters orderParameters) {
        return GetCuttingCost(orderParameters) + GetBendingCost(orderParameters) +
               GetMetalInsertsCost(orderParameters);
    }
    
    private static double GetBendingCost(OrderParameters orderParameters) {
        const double costForFew = 200;
        const double costForMany = 100;
        return orderParameters.MetalBends > 20
            ? costForMany * orderParameters.MetalBends
            : costForFew * orderParameters.MetalBends;
    }

    private static double GetSquare(OrderParameters orderParameters) {
        return orderParameters.Lenght * orderParameters.Width * 0.000001 * orderParameters.DetailsNumber;
    }

    private static double GetMass(OrderParameters orderParameters) {
        return orderParameters.Lenght * orderParameters.Width * orderParameters.Thickness * orderParameters.DetailsNumber * MagicNumber;
    }

    private static double GetMetalCost(OrderParameters orderParameters) {
        return GetMass(orderParameters) * 100;
    }

    private double GetCuttingCost(OrderParameters orderParameters) {
        var cuttingPrice = double.MaxValue;
        for (var i = 0; i < _list.Length; ++i) {
            if (orderParameters.Thickness == _list[i] && orderParameters.CuttingLength <= 100) {
                cuttingPrice = _priceListForShort[i];
            }else if (orderParameters.Thickness == _list[i] && orderParameters.CuttingLength > 100) {
                cuttingPrice = _priceListForLong[i];
            }
        }

        var capitalismThings = cuttingPrice * orderParameters.CuttingLength;
        return capitalismThings > 5000 ? capitalismThings : 5000;
    }

    private static double GetMetalInsertsCost(OrderParameters orderParameters) {
        return orderParameters.MetalInserts * 5;
    }
}