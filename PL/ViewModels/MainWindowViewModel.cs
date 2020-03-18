using PL.Views.UserControls;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;

namespace PL.ViewModels
{
    public class MainWindowViewModel : BindableBase, INavigateAsync
    {
        private readonly IRegionManager _regionManager;
        private string _title = "Prism Application";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public DelegateCommand AddClick => (new DelegateCommand(() => {
            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(ClientCartUserControl));
        }));
        public MainWindowViewModel(IRegionManager regionManager)
        {
            var parameters = new NavigationParameters();
            parameters.Add("title", "New Title");
            parameters.Add("Object",52);
            this._regionManager = regionManager;
            _regionManager?.RequestNavigate("ContentRegion", "ClientCartUserControl");
           // _regionManager?.RegisterViewWithRegion("ContentRegion", typeof(ClientCartUserControl));

        }

        public void RequestNavigate(Uri target, Action<NavigationResult> navigationCallback)
        {
            throw new NotImplementedException();
        }

        public void RequestNavigate(Uri target, Action<NavigationResult> navigationCallback, NavigationParameters navigationParameters)
        {
            throw new NotImplementedException();
        }
    }
}
