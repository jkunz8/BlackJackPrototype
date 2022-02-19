using System;
using BlackJackPrototype.Model;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BlackJackPrototype.ViewModel
{   
    public class DealCommand : ButtonCommand
    {
        public DealCommand(Table _model, BlackJackViewModel _vm) : base(_model, _vm) { }
        public override void Execute(object parameter)
        {
            _model.Deal(_vm.BetValue);
            _vm.RefreshData();
        }
    }
}