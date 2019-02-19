using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms.Integration;

namespace BeamToolHost
{
    public class BeamToolWindowsFormsHost : WindowsFormsHost
    {
        public static readonly DependencyProperty ShowToolBarProperty = DependencyProperty.Register("ShowToolBar", typeof(bool), typeof(BeamToolWindowsFormsHost), new FrameworkPropertyMetadata(true, new PropertyChangedCallback(OnShowToolBarChanged), new CoerceValueCallback(OnCoerceShowToolBar)));
        

        private static object OnCoerceShowToolBar(DependencyObject o, object value)
        {
            BeamToolWindowsFormsHost beamToolWindowsFormsHost = o as BeamToolWindowsFormsHost;
            if (beamToolWindowsFormsHost != null)
                return beamToolWindowsFormsHost.OnCoerceShowToolBar((bool)value);
            else
                return value;
        }

        private static void OnShowToolBarChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            BeamToolWindowsFormsHost beamToolWindowsFormsHost = o as BeamToolWindowsFormsHost;
            if (beamToolWindowsFormsHost != null)
                beamToolWindowsFormsHost.OnShowToolBarChanged((bool)e.OldValue, (bool)e.NewValue);
        }

        protected virtual bool OnCoerceShowToolBar(bool value)
        {
            // TODO: Keep the proposed value within the desired range.
            return value;
        }

        protected virtual void OnShowToolBarChanged(bool oldValue, bool newValue)
        {
            // TODO: Add your property changed side-effects. Descendants can override as well.
        }

        public bool ShowToolBar
        {
            // IMPORTANT: To maintain parity between setting a property in XAML and procedural code, do not touch the getter and setter inside this dependency property!
            get
            {
                return (bool)GetValue(ShowToolBarProperty);
            }
            set
            {
                SetValue(ShowToolBarProperty, value);
            }
        }

    }
}
