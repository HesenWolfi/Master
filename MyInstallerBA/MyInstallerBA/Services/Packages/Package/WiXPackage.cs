using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSO.Installs.Installer.Services.Interfaces;

namespace WSO.Installs.Installer.Services
{
    public class WiXPackage : IWiXPackage
    {
        public WiXPackage()
        {
        }
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public PackageType? PackageType { get; set; }
        public bool? Permanent { get; set; }
        public bool? Vital { get; set; }
        public bool? DisplayInternalUI { get; set; }
        public string ProductCode { get; set; }
        public string UpgradeCode { get; set; }
        public string InstallCondition { get; set; }
        public string DetectCondition { get; set; }
        public bool IsDetected { get; set; }
        public bool WillInstall { get; set; }
    }
}
