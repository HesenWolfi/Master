using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSO.Installs.Installer.PreRequisites
{
    interface IPreRequisiteViewModel
    {
        string Name { get; }
        string Id { get; }
        bool IsRequired { get; set; }
        bool IsSelected { get; set; }
        bool IsInstalled { get; set; }
    }
}
