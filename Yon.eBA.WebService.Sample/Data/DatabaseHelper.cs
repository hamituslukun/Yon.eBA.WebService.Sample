using eBAConfigurationHelper;
using eBADB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Yon.eBA.WebService.Sample.Data
{
    public class DatabaseHelper
    {
        public static eBADBProvider Provider
        {
            get
            {
                return ApplicationConfig.CreateDatabaseConnection();
            }
        }
    }
}