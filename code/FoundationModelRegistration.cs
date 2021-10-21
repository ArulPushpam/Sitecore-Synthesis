using Synthesis.Configuration.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecon.Foundation.Synthesis
{
    public abstract class FoundationModelRegistration : BaseHelixModuleRegisteration
  {
    protected override string HelixModuleType => "Foundation";
  }
}
