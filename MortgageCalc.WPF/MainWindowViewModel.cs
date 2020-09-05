using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Calculator;
using Prism.Commands;

namespace MortgageCalc.WPF
{
    class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            History = new ObservableCollection<MortgageCalculator>();
            Calculator = new MortgageCalculator();
            Calculator.MyMortgageAmount = 350000;
            Calculator.MyInterestRate = 0.04;
            Calculator.MyMortgagePeriod = 30;

            CalculateCommand = new DelegateCommand(() =>
            {
                Calculator.MortgagePaymentCalculator();
                History.Add(Calculator);

                Calculator = Calculator.Clone() as MortgageCalculator;
                RaisePropertyChanged(nameof(Calculator));
            });
        }

        public MortgageCalculator Calculator { get; private set; }

        public DelegateCommand CalculateCommand { get; private set; }

        public ObservableCollection<MortgageCalculator> History { get; set; }
        
    }
}
