using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSO.Installs.Installer.PreRequisites;

namespace WSO.Installs.Installer.Services
{
    interface IPreRequisitesRepository
    {
        Task<List<IPreRequisiteViewModel>> GetAllPreRequisitesAsync();
    }
}
