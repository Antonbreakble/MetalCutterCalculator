namespace MetalCutterCalculator.Models; 

public class OrderParameters {
    public uint Lenght { get; set; }
    public uint Width { get; set; }
    public uint Thickness { get; set; }
    public uint DetailsNumber { get; set; }
    public double CuttingLength { get; set; }
    public uint MetalInserts { get; set; }
    public uint MetalBends { get; set; }
}