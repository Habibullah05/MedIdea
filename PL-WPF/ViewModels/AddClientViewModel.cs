using Core.Abstractions;
using Core.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Windows;

namespace PL_WPF.ViewModels
{
    public class AddClientViewModel : BindableBase, IDialogAware
    {
        private readonly IAddClientService _addClientService;
        public ClientCart ClientCart;

        private DelegateCommand<string> _closeDialogCommand;
        public DelegateCommand<string> CloseDialogCommand =>
            _closeDialogCommand ?? (_closeDialogCommand = new DelegateCommand<string>(CloseDialog));
        public AddClientViewModel(IAddClientService addClientService) => _addClientService = addClientService;


        private DelegateCommand _addClick;

        public event Action<IDialogResult> RequestClose;

        public DelegateCommand AddClick => _addClick ?? (_addClick = new DelegateCommand(() =>
        {

            MessageBox.Show(ClientCart.BirthDay.ToString());

        }));

        public string MyProperty { get; set; }

        public string Title => throw new NotImplementedException();
        protected virtual void CloseDialog(string parameter)
        {
            ButtonResult result = ButtonResult.None;

            if (parameter?.ToLower() == "true")
                result = ButtonResult.OK;
            else if (parameter?.ToLower() == "false")
                result = ButtonResult.Cancel;

            RaiseRequestClose(new DialogResult(result));
        }

        public virtual void RaiseRequestClose(IDialogResult dialogResult)
        {
            RequestClose?.Invoke(dialogResult);
        }
        public bool CanCloseDialog()
        {
            throw new NotImplementedException();
        }

        public void OnDialogClosed()
        {
            throw new NotImplementedException();
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}
