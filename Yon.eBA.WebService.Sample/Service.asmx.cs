using eBAPI.Workflow;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using Yon.eBA.WebService.Sample.Data;

namespace Yon.eBA.WebService.Sample
{
    /// <summary>
    /// Summary description for Service
    /// </summary>
    [WebService(Namespace = "http://azure.yon.com.tr")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class Service : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public DataTable ExecuteIntegrationQuery(string Connection, string Query)
        {
            return IntegrationHelper.GetDataFromIntegration(Connection, Query);
        }

        [WebMethod]
        public DataTable ExecuteSqlQuery(string Query)
        {
            return DatabaseHelper.Provider.GetDataTable(Query);
        }
    }
}
