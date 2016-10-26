using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSO.Installs.Installer.Services.Interfaces;

namespace WSO.Installs.Installer.Services
{
    public class WiXPackages : IWiXPackages
    {
        public WiXPackages()
        {
            
        }
        public async Task<List<IWiXPackage>> GetAllPackages()
        {
            return await new Task<List<IWiXPackage>>();
        }
    }
}
