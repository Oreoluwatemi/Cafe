using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE5231_RNA_FinalProject_JoesCafe {
  class Connection {
    public static SqlConnection GetConnection() {
      string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ITE5231_RNA_FinalProject_JoesCafe.Properties.Settings.ITE5231_RNA_FinalProject_JoesCafeConnectionString"].ConnectionString;
      SqlConnection connection = new SqlConnection(connectionString);
      return connection;
    }
  }
}
