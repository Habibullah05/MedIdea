using Prism.Ioc;
using PL.Views;
using System.Windows;
using PL.Views.Windows;
using PL.Views.UserControls;

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

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ClientCartUserControl>();
            containerRegistry.RegisterForNavigation<VisitUserControl>();
        }
    }
}
