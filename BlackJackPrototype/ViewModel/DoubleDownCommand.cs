using System;
using BlackJackPrototype.Model;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BlackJackPrototype.ViewModel
{   
    public class DoubleDownCommand : ButtonCommand
    {
        public DoubleDownCommand(Table _model, BlackJackViewModel _vm) : base(_model, _vm) { }
        public override void Execute(object parameter)
        {
            _model.DoubleDownPlayer(_model.Creator);
            _vm.RefreshData();
        }
    }
}