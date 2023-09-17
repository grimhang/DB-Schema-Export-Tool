using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Schema_Export_Tool
{
    public static class MsSqlCommon
    {
        public const string Prefix_Database = "01_Database";
        public const string Prefix_Role = "02_Role";
        public const string Prefix_Seq = "03_Seq";
        public const string Prefix_Type = "04_Type";
        public const string Prefix_Function = "05_Function";
        public const string Prefix_Table = "06_Table";
        public const string Prefix_View = "07_View";
        public const string Prefix_Proc = "08_Proc";
        public const string Prefix_Etc = "20_Etc";
    }
}
