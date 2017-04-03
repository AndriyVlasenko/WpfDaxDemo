

using Prism.Modularity;
using Prism.Regions;
using WpfDaxxDemo.GradeTemplate.Views;

namespace WpfDaxxDemo.GradeTemplate
{
    public class GradeTemplateModule: IModule
    {
        IRegionManager _regionManager;

        public GradeTemplateModule(RegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("GradeTemplateRegion", typeof(ViewGradeTemplate));
        }
    }
}
