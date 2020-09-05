using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Calculator;
using Prism.Commands;
using System.Threading.Tasks;
using System.Linq;
using System.ComponentModel;

namespace MortgageCalc.WPF
{
    class MainWindowViewModel : BindableBase, INotifyPropertyChanged
    {
        public MainWindowViewModel(RealFileProvider realFileProvider)
        {
            History = new ObservableCollection<MortgageCalculator>();
            Calculator = new MortgageCalculator();
            Calculator.MyMortgageAmount = 350000;
            Calculator.MyInterestRate = 0.04;
            Calculator.MyMortgagePeriod = 30;
            this.fileProvider = realFileProvider;

            CalculateCommand = new DelegateCommand(() =>
            {
                Calculator.MortgagePaymentCalculator();
                History.Add(Calculator);
                ExportToExcel.RaiseCanExecuteChanged();

                Calculator = Calculator.Clone() as MortgageCalculator;
                RaisePropertyChanged(nameof(Calculator));
            });
        }

        public MortgageCalculator Calculator { get; private set; }

        public DelegateCommand CalculateCommand { get; private set; }

        public ObservableCollection<MortgageCalculator> History { get; set; }

        private bool isBusy;
        public bool IsBusy
        {
            get => isBusy;
            set
            {
                SetProperty(ref isBusy, value);
                ImportFromExcel.RaiseCanExecuteChanged();
            }
        }

        private DelegateCommand importFromExcel;
        public DelegateCommand ImportFromExcel => importFromExcel ??= new DelegateCommand(
            async () =>
            {
                IsBusy = true;
                var rows = await fileProvider.ReadParametersFromExcelAsync(ImportFilePath);
                await Task.Run(() =>
                {
                    Parallel.ForEach(rows, r => r.MortgagePaymentCalculator());
                });
                History.AddRange(rows);
                ExportToExcel.RaiseCanExecuteChanged();
                Calculator = rows.Last().Clone() as MortgageCalculator;
                IsBusy = false;
            },
            () =>
            {
                return fileProvider.FileExists(ImportFilePath) && !IsBusy;
            }
        );
        private DelegateCommand exportToExcel;
        public DelegateCommand ExportToExcel => exportToExcel ??= new DelegateCommand(
            () =>
            {
                fileProvider.ExportToExcel(History);
            },
            () =>
            {
                return History.Any();
            });

        private string importFilePath;
        private readonly IFileProvider fileProvider;

        public string ImportFilePath
        {
            get => importFilePath;
            set
            {
                importFilePath = value;
                RaisePropertyChanged(nameof(ImportFilePath));
                ImportFromExcel.RaiseCanExecuteChanged();
            }
        }
        
    }
}
