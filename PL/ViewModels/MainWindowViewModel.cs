using Prism.Mvvm;
using Prism.Regions;

namespace PL.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager regionManager;
        private string _title = "Prism Application";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IRegionManager regionManager)
        {
           
            this.regionManager = regionManager;
            regionManager.RequestNavigate("ContentRegion", "ClientCartUserControl");
        }
    }
}
