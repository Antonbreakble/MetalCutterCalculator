namespace MetalCutterCalculator.Models; 

public class OrderParameters {
    public double Width { get; set; }
    public double Height { get; set; }
    public double Thickness { get; set; }
    public uint DetailsNumber { get; set; }
    public double CuttingLength { get; set; }
    public uint MetalInserts { get; set; }
    public uint MetalBends { get; set; }
}