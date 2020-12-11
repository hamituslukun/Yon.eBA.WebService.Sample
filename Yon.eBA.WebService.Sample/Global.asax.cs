using eBAAssemblyResolver;
using eBAConfigurationHelper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Yon.eBA.WebService.Sample
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Resolver.AddPath(@ConfigurationManager.AppSettings["eBACommonPath"]);
            Resolver.AttachResolveEvent();
            Web.SetInstance();
        }
    }
}