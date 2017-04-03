

using Prism.Modularity;
using Prism.Regions;
using WpfDaxxDemo.TruckInDetails.Views;

namespace WpfDaxxDemo.TruckInDetails
{
    public class TruckInDetailsModule : IModule
    {
        IRegionManager _regionManager;

        public TruckInDetailsModule(RegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("TruckInDetailsRegion", typeof(ViewTruckInDetails));
        }
    }
}
