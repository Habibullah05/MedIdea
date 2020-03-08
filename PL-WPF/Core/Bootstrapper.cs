using CommonServiceLocator;
using PL_WPF.Views;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Unity;
using System.Windows;
using Core.Abstractions;
using BLL.Services;
using DAL.Repositories;
using PL_WPF.ViewModels;

namespace PL_WPF.Core
{
    [System.Obsolete]
    public class Bootstrapper : UnityBootstrapper
    {

        protected override DependencyObject CreateShell()
        {
            return ServiceLocator.Current.GetInstance<MainWindow>();
        }
        protected override void InitializeShell()
        {
            base.InitializeShell();
            App.Current.MainWindow = (Window)this.Shell;
            App.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
        }
        protected override void ConfigureContainer()
        {
            //Container.RegisterTypeForNavigation<IMedContext, MedContext>();
            //Container.RegisterTypeForNavigation<MainWindow, MainWindowViewModel>();

            //base.ConfigureContainer();
           // RegisterTypeIfMissing(typeof(IMedContext), typeof(MedContext),true);
            
            //Container.Registrations<> ( AddClientViewModel);
            //RegisterTypeIfMissing(typeof(IMedContext), typeof(MedContext), true);


            // Container.RegisterType<MainWindow>(new MainWindowViewModel());
            //Container.RegisterType<IMedContext, MedContext>(new MedContext());
            //Container.RegisterType(typeof(ClientCartWindowShow));

            //Container.RegisterInstance(typeof(ClientService));
        }

        //protected override void RegisterTypes(IContainerRegistry containerRegistry)
        //{
        //   // ViewModelLocationProvider.Register<AddWindow, AddClientViewModel>();

        //    //  containerRegistry.Register<i>(new C);
        //    ////throw new NotImplementedException();
        //}

    }
}
