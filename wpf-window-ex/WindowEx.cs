
using System;

namespace IVSoftware
{
    public partial class Window : System.Windows.Window
    {
        public Window()
        {
            Loaded += (object sender, System.Windows.RoutedEventArgs e)=> { };
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);
        }
        protected virtual void OnLoaded(System.Windows.RoutedEventArgs e) {  }
        public event EventHandler HandleCreated;
        protected virtual void OnHandleCreated (System.Windows.RoutedEventArgs e) 
        {
            HandleCreated?.Invoke(this, e);
        }
    }
}