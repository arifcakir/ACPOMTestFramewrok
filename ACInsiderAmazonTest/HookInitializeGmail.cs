using ACAutoTestFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACPTTTest
{
   public class HookInitializeGmail : TestInitializeHook
    {
        public HookInitializeGmail(): base(BrowserType.Chrome)
        {
            InitializeSttings();
            NavigateSiteGmail();
        }
    }
}
