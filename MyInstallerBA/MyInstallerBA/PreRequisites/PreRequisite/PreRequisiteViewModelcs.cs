using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSO.Installs.Installer.BaseClasses;

namespace WSO.Installs.Installer.PreRequisites
{
    public class PreRequisiteViewModelcs : BindableBase, IPreRequisiteViewModel
    {
        public string Name { get; }
        public string Id { get; }
        public bool IsRequired { get; set; }
        public bool IsSelected { get; set; }
        public bool IsInstalled { get; set; }
    }
}
