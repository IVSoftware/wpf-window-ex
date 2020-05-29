
using System;

namespace IVSoftware
{
    public partial class Window : System.Windows.Window
    {
        public Window()
        {
            Loaded += (object sender, System.Windows.RoutedEventArgs e) => { OnLoad(e); };
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);
            OnHandleCreated(e);
        }
        protected virtual void OnLoad(System.Windows.RoutedEventArgs e)
        {
        }
        public event EventHandler HandleCreated;
        protected virtual void OnHandleCreated(EventArgs e)
        {
            HandleCreated?.Invoke(this, e);
        }
    }
}