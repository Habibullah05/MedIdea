using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PL.ViewModels
{
    public class AddClientCartWindowViewModel : BindableBase
    {
        private DelegateCommand _fieldName;
        public DelegateCommand CommandName =>
            _fieldName ?? (_fieldName = new DelegateCommand(ExecuteCommandName));

        void ExecuteCommandName()
        {

        }
        public AddClientCartWindowViewModel()
        {

        }
    }
}
