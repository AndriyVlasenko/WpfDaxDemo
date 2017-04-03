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

namespace WpfDaxxDemo.GradeTemplate.UserControls
{
    /// <summary>
    /// Interaction logic for GradeTemplateControl.xaml
    /// </summary>
    public partial class GradeTemplateControl : UserControl
    {
        public GradeTemplateControl()
        {
            InitializeComponent();
        }

        #region Label

        /// <summary>
        /// Gets or sets the Label which is displayed next to the field
        /// </summary>
        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        /// <summary>
        /// Identified the Label dependency property
        /// </summary>
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string),
              typeof(GradeTemplateControl), new PropertyMetadata(""));

        #endregion

        #region Text

        /// <summary>
        /// Gets or sets the Text which is being displayed
        /// </summary>
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        /// <summary>
        /// Identified the Label dependency property
        /// </summary>
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string),
              typeof(GradeTemplateControl), new PropertyMetadata(""));

        #endregion
    }
}
