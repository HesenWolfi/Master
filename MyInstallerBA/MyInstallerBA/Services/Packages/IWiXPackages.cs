using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSO.Installs.Installer.Services.Interfaces;

namespace WSO.Installs.Installer.Services
{
    interface IWiXPackages
    {
        Task<List<IWiXPackage>> GetAllPackages();
    }
}
