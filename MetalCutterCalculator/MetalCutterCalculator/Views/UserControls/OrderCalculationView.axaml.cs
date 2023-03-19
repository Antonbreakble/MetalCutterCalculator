using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MetalCutterCalculator.Views.UserControls; 

public partial class OrderCalculationView : UserControl {
    public OrderCalculationView() {
        InitializeComponent();
    }

    private void InitializeComponent() {
        AvaloniaXamlLoader.Load(this);
    }
}