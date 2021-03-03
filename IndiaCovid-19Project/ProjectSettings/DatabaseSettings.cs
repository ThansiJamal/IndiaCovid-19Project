using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndiaCovid_19Project.ProjectSettings
{
    public class DatabaseSettings
    {
        public static string DatabaseConnectionMSSQL = @"Server = " + Environment.MachineName + "\\SQLEXPRESS; Database = Covid-19DB; trusted_connection = true";
    }
}