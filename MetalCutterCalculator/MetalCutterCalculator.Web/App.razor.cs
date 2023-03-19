using Avalonia.Web.Blazor;

namespace MetalCutterCalculator.Web;

public partial class App {
    protected override void OnParametersSet() {
        base.OnParametersSet();

        WebAppBuilder.Configure<MetalCutterCalculator.App>()
            .SetupWithSingleViewLifetime();
    }
}