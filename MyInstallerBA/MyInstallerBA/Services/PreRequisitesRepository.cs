using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSO.Installs.Installer.PreRequisites;

namespace WSO.Installs.Installer.Services
{
    public class PreRequisitesRepository : IPreRequisitesRepository
    {
        public async Task<List<IPreRequisiteViewModel>> GetAllPreRequisitesAsync()
        {
            return await new Task<List<IPreRequisiteViewModel>>();
        }
    }
}
