using System.Windows;
using Microsoft.Practices.Unity;
using Prism.Unity;
using WpfDaxxDemo.Shell.Views;
using Prism.Modularity;
using WpfDaxxDemo.Workstation;
using WpfDaxxDemo.TruckInDetails;
using WpfDaxxDemo.GradeTemplate;
using WpfDaxxDemo.Simulator;
using WpfDaxxDemo.IntransitList;

namespace WpfDaxxDemo.Shell
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
        }

        protected override void ConfigureModuleCatalog()
        {
            var catalog = (ModuleCatalog)ModuleCatalog;
            catalog.AddModule(typeof(WorkstationModule));
            catalog.AddModule(typeof(TruckInDetailsModule));
            catalog.AddModule(typeof(GradeTemplateModule));
            catalog.AddModule(typeof(SimulatorModule));
            catalog.AddModule(typeof(IntransitListModule)); 
        }
    }
}
