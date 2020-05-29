using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace IVSoftware
{
    public class Console : TextBox, IConsole
    {
        public void ReadKey()
        {
            _waiting = true;
            AppendText("Press any key to continue..." + Environment.NewLine);
            while (_waiting)
            {
                Thread.Sleep(0);        // Pump Message Queue
                Task.Delay(100).Wait();
            }
            AppendText("Execution has resumed.");
        }
        public void WriteLine(string text = "")
        {
            AppendText(text + Environment.NewLine);
        }
        public void Write(string text = "")
        {
            AppendText(text);
        }
        protected override void OnKeyDown(
           KeyEventArgs e
        )
        {
            if (_waiting) _waiting = false;
        }
        bool _waiting = false;
    }
    public interface IConsole
    {
        void Write(string text = "");
        void WriteLine(string text = "");
        void ReadKey();
    }
}
