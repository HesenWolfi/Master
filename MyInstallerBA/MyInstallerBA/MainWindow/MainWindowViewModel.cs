using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Tools.WindowsInstallerXml.Bootstrapper;
using WSO.Installs.Installer.BaseClasses;
using WSO.Installs.Installer.MainWindow;
using WSO.Installs.Installer.PreRequisites;

namespace WSO.Installs.Installer
{
    public class MainWindowViewModel : BindableBase, IMainWindowViewModel
    {
        private PreRequisitesListViewModel _preRequisitesListViewModel = new PreRequisitesListViewModel();
        private WelcomeDlgViewModel _welcomeDlgViewModel = new WelcomeDlgViewModel();

        private BindableBase _currentViewModel;

        public MainWindowViewModel()
        {
            CurrentViewModel = WelcomeDlgViewModel;
        }
        public BootstrapperApplication Bootstrapper { get; private set; }

        public MainWindowViewModel(BootstrapperApplication bootstrapperApplication) : this()
        {
            this.Bootstrapper = bootstrapperApplication;
            this.Bootstrapper.ApplyComplete += OnApplyComplete;
            this.Bootstrapper.CacheComplete += OnCacheComplete;
            this.Bootstrapper.CacheAcquireComplete += OnCacheAcquireComplete;
            this.Bootstrapper.CachePackageComplete += OnCachePackageComplete;
            this.Bootstrapper.CacheVerifyComplete += OnCacheVerifyComplete;
            this.Bootstrapper.DetectComplete += OnDetectComplete;
            this.Bootstrapper.DetectPackageComplete += OnDetectPackageComplete;
            this.Bootstrapper.DetectUpdateComplete += OnDetectUpdateComplete;
        }

        private void OnDetectUpdateComplete(object sender, DetectUpdateCompleteEventArgs e)
        {
            return;
        }

        private void OnDetectPackageComplete(object sender, DetectPackageCompleteEventArgs e)
        {
            return;
        }

        private void OnDetectComplete(object sender, DetectCompleteEventArgs e)
        {
            return;
        }

        private void OnCacheVerifyComplete(object sender, CacheVerifyCompleteEventArgs e)
        {
            return;
        }

        private void OnCachePackageComplete(object sender, CachePackageCompleteEventArgs e)
        {
            return;
        }

        private void OnCacheAcquireComplete(object sender, CacheAcquireCompleteEventArgs e)
        {
            return;
        }

        private void OnCacheComplete(object sender, CacheCompleteEventArgs e)
        {
            return;
        }

        private void OnApplyComplete(object sender, ApplyCompleteEventArgs e)
        {
            return;
        }

        public BindableBase CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }

            set
            {
                SetProperty(ref _currentViewModel, value);
            }
        }
    }
}
