using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Csharp1.Startup))]

namespace Csharp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            

            ConfigureAuth(app);
        }
    }
}
