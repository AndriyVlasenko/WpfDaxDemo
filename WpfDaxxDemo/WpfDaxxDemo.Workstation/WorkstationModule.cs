
using Prism.Modularity;
using Prism.Regions;
using WpfDaxxDemo.Workstation.Views;

namespace WpfDaxxDemo.Workstation
{
    public class WorkstationModule : IModule
    {
        IRegionManager _regionManager;

        public WorkstationModule(RegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("WorkstationTabRegion", typeof(ViewWorkstationTab));
            _regionManager.RegisterViewWithRegion("WorkstationRegion", typeof(ViewWorkstation));
        }
    }
}
