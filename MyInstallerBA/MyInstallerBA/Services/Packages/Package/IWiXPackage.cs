using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSO.Installs.Installer.Services.Interfaces
{
    public enum PackageType
    {
        EXE,
        MSI,
        MSP,
        MSU,
    }

    interface IWiXPackage
    { 
        string Id { get; set; }
        string DisplayName { get; set; }
        string Description { get; set; }
        PackageType? PackageType { get; set; }
        bool? Permanent { get; set; }
        bool? Vital { get; set; } 
        bool? DisplayInternalUI { get; set; }
        string ProductCode { get; set; }
        string UpgradeCode { get; set; }
        string InstallCondition { get; set; }
        string DetectCondition { get; set; }
        bool IsDetected { get; set; }
        bool WillInstall { get; set; }
    }
}
