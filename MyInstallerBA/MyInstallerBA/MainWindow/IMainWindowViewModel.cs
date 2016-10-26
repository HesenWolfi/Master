using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSO.Installs.Installer.BaseClasses;

namespace WSO.Installs.Installer.MainWindow
{
    interface IMainWindowViewModel
    {
        BindableBase CurrentViewModel { get; set; }
    }
}
