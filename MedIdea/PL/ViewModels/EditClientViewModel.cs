using MedIdea.ViewModels.Base;
using MedIdea.Views;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MedIdea.ViewModels
{
    public class EditClientViewModel: BindableBase
    {
        private DelegateCommand _editClick;
        public DelegateCommand EditClick => _editClick ?? (_editClick = new DelegateCommand(() => {
           

        }));
        public string MyProperty { get; set; }
        Guid ClientId;
        public EditClientViewModel() { }
        public EditClientViewModel(Guid id) => ClientId =id; 





    }
}
