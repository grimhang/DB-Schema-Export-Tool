﻿
using Microsoft.SqlServer.Management.Dmf;

namespace DB_Schema_Export_Tool
{
    public class ServerConnectionInfo
    {
        /// <summary>
        /// Server name
        /// </summary>
        public string ServerName { get; set; }
        
        /// <summary>
        /// Database user name
        /// </summary>
        public string UserName { get; set; }
        
        /// <summary>
        /// Database user password
        /// </summary>
        public string Password { get; set; }
        
        /// <summary>
        /// When true, use integrated authentication (and thus UserName and Password are ignored)
        /// </summary>
        public bool UseIntegratedAuthentication { get; set; }

        /// <summary>
        /// Database server port (only applicable to PostgreSQL)
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// True when connecting to a PostgreSQL database
        /// </summary>
        public bool PostgreSQL { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="serverName"></param>
        /// <param name="useIntegrated"></param>
        public ServerConnectionInfo(string serverName, bool useIntegrated)
        {
            Reset();
            ServerName = serverName;
            UseIntegratedAuthentication = useIntegrated;
        }

        /// <summary>
        /// Reset to empty strings
        /// </summary>
        public void Reset()
        {
            ServerName = string.Empty;
            UserName = string.Empty;
            Password = string.Empty;
            UseIntegratedAuthentication = true;
            Port = DBSchemaExporterPostgreSQL.DEFAULT_PORT;
            PostgreSQL = false;
        }

        /// <summary>
        /// Update the cached server info
        /// </summary>
        /// <param name="options"></param>
        public void UpdateInfo(SchemaExportOptions options)
        {
            ServerName = options.ServerName;
            UserName = options.DBUser;
            Password = options.DBUserPassword;
            UseIntegratedAuthentication = options.UseIntegratedAuthentication;
            Port = options.PgPort;
            PostgreSQL = options.PostgreSQL;
        }
    }
}
