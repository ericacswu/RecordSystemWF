using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace RecordSystemWF.Helper
{
    public static class DbContextExtensions
    {
        private static readonly ILogger _logger;
        public static async Task<DataTable> DataTable(this DbContext context, string sqlQuery, params DbParameter[] parameters)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            DataTable dataTable = new DataTable();
            using (var connection = context.Database.GetDbConnection())
            {
                DbProviderFactory dbFactory = DbProviderFactories.GetFactory(connection);
                using (var cmd = dbFactory.CreateCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sqlQuery;

                    if (string.IsNullOrEmpty(connection.ConnectionString))
                    {
                        cmd.Connection.ConnectionString = connectionString;
                    }
                    if (cmd.Connection.State == ConnectionState.Closed)
                    {
                        connectionString = connection.ConnectionString;
                        await cmd.Connection.OpenAsync();
                    }
                    if (parameters != null)
                    {
                        foreach (var item in parameters)
                        {
                            cmd.Parameters.Add(item);
                        }
                    }
                    using (DbDataAdapter adapter = dbFactory.CreateDataAdapter())
                    {
                        try
                        {
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dataTable);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogError("DB DataAdapter Error" + ":" + ex);
                        }
                    }
                }
            }

            return dataTable;
        }
    }
}
