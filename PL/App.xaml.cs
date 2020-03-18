using Prism.Ioc;
using System.Windows;
using PL.Views.Windows;
using PL.Views.UserControls;
using Prism.Modularity;
using Prism.DryIoc;
using PL.Views;
using PL.ViewModels;

namespace PL
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App 
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
        protected override IModuleCatalog CreateModuleCatalog()
        {
            return base.CreateModuleCatalog();  
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
            containerRegistry.RegisterForNavigation<ClientCartUserControl, ClientCartUserControlViewModel>();
            containerRegistry.RegisterForNavigation<VisitUserControl>();
           // containerRegistry.Register<object, ClientCartUserControl>("InboxView");
            //regionManager.Regions[Constants.MainRegion].RequestNavigate(new Uri("InboxView", UriKind.Relative));
            //  containerRegistry.Register(typeof(ClientCartUserControl));
        }
    }
}
