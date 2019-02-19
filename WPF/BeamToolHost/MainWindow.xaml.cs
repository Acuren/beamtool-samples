using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ESBeamTool;

namespace BeamToolHost
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();

            theHost.PropertyMap.Add("ShowToolBar", new PropertyTranslator(OnShowToolBarChanged));
        }

        private void OkButtonClick(object sender, RoutedEventArgs e)
        {
            theHost.ShowToolBar = !theHost.ShowToolBar;

        }

        private void OnShowToolBarChanged(object host, string propertyName, object value)
        {
            BeamToolWindowsFormsHost theHost = host as BeamToolWindowsFormsHost;
            BeamToolView beamToolView = theHost.Child as BeamToolView;
            if(beamToolView != null)
            {
                beamToolView.ShowToolbar = theHost.ShowToolBar;
            }
            
            
        }
    }
}
