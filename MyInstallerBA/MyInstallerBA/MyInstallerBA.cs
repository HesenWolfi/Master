using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

using Microsoft.Tools.WindowsInstallerXml.Bootstrapper;

namespace WSO.Installs.Installer
{
    public class MyInstallerBA : BootstrapperApplication
    {
        public static Dispatcher BootstrapperDispatcher { get; private set; }

        //  Must override this to get entry point into BootstrapperApplication
        protected override void Run()
        {
            this.Engine.Log(LogLevel.Verbose, "Running the custom WPF UI.");
#if DEBUG
            // Uncomment the following line to debug bootstrapper
            // Debugger.Launch();
            while (!System.Diagnostics.Debugger.IsAttached)
            {
                System.Threading.Thread.Sleep(1000);
            }
#endif
            this.Engine.Log(LogLevel.Verbose, "Launching the Bootstrapper Override");
            BootstrapperDispatcher = Dispatcher.CurrentDispatcher;

            MainWindowViewModel viewModel = new MainWindowViewModel(this);
            viewModel.Bootstrapper.Engine.Detect();

            MainWindowView view = new MainWindowView();
            
        }
    }
}
