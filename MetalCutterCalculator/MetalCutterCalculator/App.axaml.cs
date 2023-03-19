using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using MetalCutterCalculator.Services;
using MetalCutterCalculator.ViewModels;
using MetalCutterCalculator.Views;

namespace MetalCutterCalculator {
    public partial class App : Application {
        public override void Initialize() {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted() {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
                desktop.MainWindow = new MainWindow {
                    DataContext = new MainViewModel(new CuttingCalculationService())
                };
            }
            else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform) {
                singleViewPlatform.MainView = new MainView {
                    DataContext = new MainViewModel(new CuttingCalculationService())
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}