﻿using Prism.Modularity;
using Prism.Regions;
using WpfDaxxDemo.Simulator.Views;

namespace WpfDaxxDemo.Simulator
{
    public class SimulatorModule: IModule
    {
        IRegionManager _regionManager;

        public SimulatorModule(RegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("SimulatorRegion", typeof(ViewSimulator));
        }
    }
}
