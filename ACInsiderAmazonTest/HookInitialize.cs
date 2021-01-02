using ACAutoTestFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACPTTTest
{
    public class HookInitialize : TestInitializeHook
    {
        public HookInitialize() : base(BrowserType.Chrome)
        {
            InitializeSttings();
            NavigateSite();
        }
     
    }
}
