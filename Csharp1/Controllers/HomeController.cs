using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Csharp1.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            System.Configuration.Configuration rootWebConfig1 =
                System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(null);
            if (rootWebConfig1.AppSettings.Settings.Count > 0)
            {
                System.Configuration.KeyValueConfigurationElement emailAccountSetting =
                    rootWebConfig1.AppSettings.Settings["emailAccount"];
                if (emailAccountSetting != null)
                    Console.WriteLine("customsetting1 application string = \"{0}\"",
                        emailAccountSetting.Value);
                else
                    Console.WriteLine("No customsetting1 application string");
            }


            return View();
        }
    }
}
