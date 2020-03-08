using PL_WPF.Core;
using System.Windows;

namespace PL_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        
        [System.Obsolete]
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
           
            Bootstrapper bootstrapper = new Bootstrapper();
            bootstrapper.Run();
            
        }
        
    }
}
