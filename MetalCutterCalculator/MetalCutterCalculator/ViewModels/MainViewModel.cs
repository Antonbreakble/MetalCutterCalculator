using System.Collections.ObjectModel;
using System.Reactive;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MetalCutterCalculator.Models;
using MetalCutterCalculator.Services;
using MetalCutterCalculator.ViewModels.UserControls;


namespace MetalCutterCalculator.ViewModels {
    public partial class MainViewModel : ViewModelBase {
        private readonly ICuttingCalculationService _cuttingCalculationService;

        [ObservableProperty] private OrderParametersViewModel _orderParametersViewModel = new();

        public MainViewModel(ICuttingCalculationService cuttingCalculationService) {
            _cuttingCalculationService = cuttingCalculationService;
        }
        
        [RelayCommand]
        private void CalculateOrder() {
            var orderCalculation = _cuttingCalculationService.CalculateOrderByOrderParameters(_orderParametersViewModel.GetOrderParameters());
        }
    }
}