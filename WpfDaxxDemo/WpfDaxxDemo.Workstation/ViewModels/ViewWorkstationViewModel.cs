using Prism.Mvvm;

namespace WpfDaxxDemo.Workstation.ViewModels
{
    public class ViewWorkstationViewModel : BindableBase
    {
        public ViewWorkstationViewModel()
        {
            WorkStation = "Dual probe Workstation";
            User = "Alex Oleynikov";
            Mode = "Edit";
        }

        private string _workstation = null;
        public string WorkStation
        {
            get { return _workstation; }
            set { SetProperty(ref _workstation, value); }
        }

        private string _user = null;
        public string User
        {
            get { return _user; }
            set { SetProperty(ref _user, value); }
        }

        private string _mode = null;
        public string Mode
        {
            get { return _mode; }
            set { SetProperty(ref _mode, value); }
        }
    }
}
