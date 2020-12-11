using eBAPI.Connection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Yon.eBA.WebService.Sample.Data
{
    public class ConnectionHelper
    {
        public static eBAConnection Connection
        {
            get
            {
                return new eBAConnection
                {
                    Server = ConfigurationManager.AppSettings["eBAServer"],
                    UserID = ConfigurationManager.AppSettings["UserId"],
                    Password = ConfigurationManager.AppSettings["Password"]
                };
            }

        }
    }
}