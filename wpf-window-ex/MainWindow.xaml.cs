using System;
using System.Windows;
using Window = IVSoftware.Window;

namespace wpf_window_ex
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Console.WriteLine("Native window handle has been created.");
        }
        protected override void OnLoad(RoutedEventArgs e)
        {
            base.OnLoad(e);
            Console.WriteLine("Form has loaded and ready to interact.");
        }
    }
}
