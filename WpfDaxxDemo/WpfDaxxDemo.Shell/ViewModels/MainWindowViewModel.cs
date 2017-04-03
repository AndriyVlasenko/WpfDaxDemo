using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Windows.Threading;
using WpfDaxxDemo.Shell.ShowAnimation;

namespace WpfDaxxDemo.Shell.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IEventAggregator _eventAggregator;

        private string _currentTime;

        public DispatcherTimer _timer;

        public string CurrentTime
        {
            get { return _currentTime; }
            set { SetProperty(ref _currentTime, value); }
        }
        public DelegateCommand DataCommand { get; set; }
        public DelegateCommand OptionsCommand { get; set; }
        public DelegateCommand ReportsCommand { get; set; }
        public DelegateCommand ReprintCommand { get; set; }
        public DelegateCommand AnalysisCommand { get; set; }
        public DelegateCommand ToolsCommand { get; set; }
        public DelegateCommand WorkStationsCommand { get; set; }
        public DelegateCommand HelpCommand { get; set; }

        public MainWindowViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            DataCommand = new DelegateCommand(DataCommandExecute, CanExecute);
            OptionsCommand = new DelegateCommand(OptionsCommandExecute, CanExecute);
            ReportsCommand = new DelegateCommand(ReportsCommandExecute, CanExecute);
            ReprintCommand = new DelegateCommand(ReprintCommandExecute, CanExecute);
            AnalysisCommand = new DelegateCommand(AnalysisCommandExecute, CanExecute);
            ToolsCommand = new DelegateCommand(ToolsCommandExecute, CanExecute);
            WorkStationsCommand = new DelegateCommand(WorkStationsCommandExecute, CanExecute);
            HelpCommand = new DelegateCommand(HelpCommandExecute, CanExecute);

            _timer = new DispatcherTimer(DispatcherPriority.Render);
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += (sender, args) =>
            {
                CurrentTime = DateTime.Now.ToString("ddd  MM.dd.yy  H:mm:ss    ");
            };
            _timer.Start();
        }

        private void DataCommandExecute()
        {
            var showAnimation = new ShowAnimationWindow();
            showAnimation.Show();
        }

        private void OptionsCommandExecute()
        {
            throw new NotImplementedException();
        }

        private void ReportsCommandExecute()
        {
            throw new NotImplementedException();
        }

        private void ReprintCommandExecute()
        {
            throw new NotImplementedException();
        }

        private void AnalysisCommandExecute()
        {
            throw new NotImplementedException();
        }

        private void ToolsCommandExecute()
        {
            throw new NotImplementedException();
        }

        private void WorkStationsCommandExecute()
        {
            throw new NotImplementedException();
        }

        private void HelpCommandExecute()
        {
            throw new NotImplementedException();
        }

        private bool CanExecute()
        {
            return true;
        }        
    }
}
