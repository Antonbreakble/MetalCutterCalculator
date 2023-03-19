using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MetalCutterCalculator.Views.UserControls; 

public partial class OrderParametersView : UserControl {
    public OrderParametersView() {
        InitializeComponent();
    }

    private void InitializeComponent() {
        AvaloniaXamlLoader.Load(this);
    }
}