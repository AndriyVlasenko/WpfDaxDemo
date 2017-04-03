using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDaxxDemo.Simulator.UserControls
{
    /// <summary>
    /// Interaction logic for SimulatorSemafore.xaml
    /// </summary>
    public partial class SimulatorSemaphore : UserControl
    {
        public SimulatorSemaphore()
        {
            InitializeComponent();
        }

        #region IsValid

        /// <summary>
        /// Gets or sets the Label which is displayed next to the field
        /// </summary>
        public bool IsValid
        {
            get { return (bool)GetValue(IsValidProperty); }
            set { SetValue(IsValidProperty, value); }
        }

        /// <summary>
        /// Identified the Label dependency property
        /// </summary>
        public static readonly DependencyProperty IsValidProperty =
            DependencyProperty.Register("IsValid", typeof(bool),
              typeof(SimulatorSemaphore), new PropertyMetadata(false));

        #endregion

        #region UpString

        /// <summary>
        /// Gets or sets the Label which is displayed next to the field
        /// </summary>
        public string UpString
        {
            get { return (string)GetValue(UpStringProperty); }
            set { SetValue(UpStringProperty, value); }
        }

        /// <summary>
        /// Identified the Label dependency property
        /// </summary>
        public static readonly DependencyProperty UpStringProperty =
            DependencyProperty.Register("UpString", typeof(string),
              typeof(SimulatorSemaphore), new PropertyMetadata(""));

        #endregion

        #region DownString

        /// <summary>
        /// Gets or sets the Label which is displayed next to the field
        /// </summary>
        public string DownString
        {
            get { return (string)GetValue(DownStringProperty); }
            set { SetValue(DownStringProperty, value); }
        }

        /// <summary>
        /// Identified the Label dependency property
        /// </summary>
        public static readonly DependencyProperty DownStringProperty =
            DependencyProperty.Register("DownString", typeof(string),
              typeof(SimulatorSemaphore), new PropertyMetadata(""));

        #endregion
    }
}
