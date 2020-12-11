using eBAIntegrationAPI;
using eBAPI.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Yon.eBA.WebService.Sample.Data
{
    public class IntegrationHelper
    {
        public static DataTable GetDataFromIntegration(string Connection, string Query)
        {
            return GetDataFromIntegration(Connection, Query, new Dictionary<string, string>());
        }

        public static DataTable GetDataFromIntegration(string Connection, string Query, Dictionary<string, string> Parameters)
        {
            eBAIntegrationQuery integrationQuery = new eBAIntegrationQuery(Connection, Query);

            foreach (KeyValuePair<string, string> keyValuePair in Parameters)
            {
                integrationQuery.Parameters.Add(keyValuePair.Key, keyValuePair.Value);
            }

            eBAConnection connection = ConnectionHelper.Connection;
            connection.Open();

            try
            {
                return integrationQuery.Execute(connection);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { connection.Close(); }
        }
    }
}