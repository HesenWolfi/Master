﻿using Microsoft.Tools.WindowsInstallerXml.Bootstrapper;
using System.ComponentModel.Composition;
using System.Windows;

namespace InstallerUI
{
	[Export("InstallerMainWindow", typeof(Window))]
	[PartCreationPolicy(CreationPolicy.NonShared)]
	public partial class InstallerMainWindow : Window
	{
		[ImportingConstructor]
		public InstallerMainWindow(InstallerMainWindowViewModel viewModel, Engine engine)
		{
#if DEBUG
            while (!System.Diagnostics.Debugger.IsAttached)
		    {
		        System.Threading.Thread.Sleep(1000);
		    }
#endif

            this.DataContext = viewModel;

			this.Loaded += (sender, e) => engine.CloseSplashScreen();
			this.Closed += (sender, e) => this.Dispatcher.InvokeShutdown(); // shutdown dispatcher when the window is closed.

			this.InitializeComponent();
		}
	}
}
