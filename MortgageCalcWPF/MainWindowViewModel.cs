using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace MortgageCalcWPF
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            History = new ObservableCollection<MortgageCalculator>();
        }
    }
}
