using Prism.Modularity;
using Prism.Regions;
using WpfDaxxDemo.IntransitList.Views;

namespace WpfDaxxDemo.IntransitList
{
    public class IntransitListModule : IModule
    {
        IRegionManager _regionManager;

        public IntransitListModule(RegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("IntransitListRegion", typeof(ViewIntransitList));
        }
    }
}
