using System;

namespace Sitecon.Foundation.Synthesis
{
    public abstract class ProjectModelRegistration : BaseHelixModuleRegisteration
    {
        protected override string HelixModuleType => "Project";
        protected override string HelixModuleName
        {
            get
            {
                // normally we want the last segment e.g. Sitecore.Foundation.Multisite
                // but projects break that mold and use e.g. Sitecore.Common.Website and the middle element is the name of the component
                var projectName = this.ConfigurationName.Replace(".Website", string.Empty);

                return projectName.Substring(projectName.LastIndexOf(".", StringComparison.Ordinal) + 1);
            }
        }
    }
}
