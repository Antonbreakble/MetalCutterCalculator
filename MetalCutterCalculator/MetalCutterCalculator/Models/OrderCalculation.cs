namespace MetalCutterCalculator.Models; 

public class OrderCalculation {
    public double Square { get; set; }
    public double Mass { get; set; }
    public double MetalCost { get; set; }
    public double CuttingCost { get; set; }
    public double MetalInsertsCost { get; set; }
    public double BendingCost { get; set; }
    public double CostWithInnerMetal { get; set; }
    public double CostWithOuterMetal { get; set; }
}