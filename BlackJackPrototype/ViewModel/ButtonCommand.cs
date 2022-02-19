using System;
using BlackJackPrototype.Model;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BlackJackPrototype.ViewModel
{
    public abstract class ButtonCommand : ICommand
    {
        public Table _model;
        public BlackJackViewModel _vm;
        public ButtonCommand(Table _model, BlackJackViewModel _vm)
        {
            this._model = _model;
            this._vm = _vm;
        }

        public abstract void Execute(object parameter);
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            return true;
        }
    }
}
