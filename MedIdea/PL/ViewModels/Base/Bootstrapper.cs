using CommonServiceLocator;
using MedIdea.Views;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MedIdea.ViewModels.Base
{
    public class Bootstrapper : PrismApplication
    {
        protected override Window CreateShell()
        {
            return ServiceLocator.Current.GetInstance<MainWindow>();
        }
        protected override void InitializeShell(Window shell)
        {
            //base.InitializeShell(shell);      
            Current.MainWindow = shell;
            Current.MainWindow.Show();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<MainWindow, MainViewModel>();

            //  containerRegistry.Register<i>(new C);
            ////throw new NotImplementedException();
        }
    }
}
