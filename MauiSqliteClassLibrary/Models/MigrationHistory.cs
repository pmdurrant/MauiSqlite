using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiSqliteClassLibrary.Models
{
    public class MigrationHistory
    {
        public string MigrationId { get; set; }
        public string ProductVersion { get; set; }
    }
}
