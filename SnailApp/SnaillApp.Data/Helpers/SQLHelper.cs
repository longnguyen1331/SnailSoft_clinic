using SnailApp.Data.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace SnailApp.Data.SqlHelper
{
    public static class SQLHelper
    {
        public static async Task<int> ExecuteNonQueryAsync(EShopDbContext context, string rawSql,
            params object[] parameters)
        {
            var conn = context.Database.GetDbConnection();
            using (var command = conn.CreateCommand())
            {
                try
                {
                    command.CommandText = rawSql;
                    if (parameters != null)
                        foreach (var p in parameters)
                            command.Parameters.Add(p);
                    await conn.OpenAsync();
                    int reuslt = await command.ExecuteNonQueryAsync();
                    command.Parameters.Clear();
                    await conn.CloseAsync();
                    return reuslt;
                }
                catch (Exception ex)
                {
                    string mess = ex.Message;
                    command.Parameters.Clear();
                    await conn.CloseAsync();
                    return -1;
                }
            }
        }

        public static async Task<List<T>> ExecuteScalarAsync<T>(EShopDbContext context, string rawSql,
            Func<DbDataReader, T> map, params object[] parameters)
        {

            var conn = context.Database.GetDbConnection();
            using (var command = conn.CreateCommand())
            {
                try
                {
                    command.CommandText = rawSql;
                    if (parameters != null)
                        foreach (var p in parameters)
                            command.Parameters.Add(p);


                    await conn.OpenAsync();
                    var result = await command.ExecuteReaderAsync();

                    command.Parameters.Clear();
                    var entities = new List<T>();

                    while (result.Read())
                    {
                        entities.Add(map(result));
                    }

                    await conn.CloseAsync();



                    return entities;

                }
                catch (Exception ex)
                {
                    string mess = ex.Message;
                    var entities = new List<T>();
                    command.Parameters.Clear();
                    await conn.CloseAsync();

                    return entities;
                }
            }
        }
    }
}
