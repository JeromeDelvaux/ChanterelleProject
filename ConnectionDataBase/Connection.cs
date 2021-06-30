using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace ConnectionDataBase
{
    public class Connection : IConnection
    {
        private const string ReturnValueParameterName = "___ReturnValue";
        private string _connectionString;
        private DbProviderFactory _factory;

        public Connection(DbProviderFactory factory, string connectionString)
        {
            _connectionString = connectionString;
            _factory = factory;
            using (DbConnection connection = CreateConnection())
            {

                connection.Open();
            }
        }

        public object ExecuteScalar(Commands command)
        {
            using (DbConnection connection = CreateConnection())
            {
                using (DbCommand cmd = CreateCommand(command, connection))
                {
                    connection.Open();
                    object result = cmd.ExecuteScalar();
                    FinalizeQuery(command, cmd);
                    return (result is DBNull) ? null : result;
                }
            }
        }

        public int ExecuteNonQuery(Commands command)
        {
            using (DbConnection connection = CreateConnection())
            {
                using (DbCommand cmd = CreateCommand(command, connection))
                {
                    connection.Open();
                    int rows = cmd.ExecuteNonQuery();
                    FinalizeQuery(command, cmd);
                    return rows;
                }
            }
        }

        public DataTable GetDataTable(Commands command)
        {
            using (DbConnection connection = CreateConnection())
            {
                using (DbCommand cmd = CreateCommand(command, connection))
                {
                    using (DbDataAdapter da = _factory.CreateDataAdapter())
                    {
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        FinalizeQuery(command, cmd);
                        return dt;
                    }
                }
            }
        }

        public IEnumerable<TResult> ExecuteReader<TResult>(Commands command, Func<IDataRecord, TResult> selector)
        {
            List<TResult> results = new List<TResult>();
            using (DbConnection connection = CreateConnection())
            {
                using (DbCommand cmd = CreateCommand(command, connection))
                {
                    connection.Open();
                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return selector(reader);
                        }
                        FinalizeQuery(command, cmd);
                    }
                }
            }
        }

        private DbCommand CreateCommand(Commands command, DbConnection connection)
        {
            DbCommand cmd = connection.CreateCommand();
            cmd.CommandText = command.Query;
            if (command.Stored)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DbParameter returnValueParameter = cmd.CreateParameter();
                returnValueParameter.ParameterName = ReturnValueParameterName;
                returnValueParameter.Value = 0;
                returnValueParameter.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(returnValueParameter);
            }
            foreach (KeyValuePair<string, object> kvp in command.Params)
            {
                DbParameter parameter = _factory.CreateParameter();
                parameter.ParameterName = kvp.Key;
                parameter.Value = kvp.Value;

                cmd.Parameters.Add(parameter);
            }
            return cmd;
        }

        private DbConnection CreateConnection()
        {
            DbConnection sqlConnection = _factory.CreateConnection();
            sqlConnection.ConnectionString = _connectionString;
            return sqlConnection;
        }
        private void FinalizeQuery(Commands command, DbCommand dbCommand)
        {
            if (command.Stored)
            {
                command.ReturnValue = dbCommand.Parameters[ReturnValueParameterName].Value is DBNull ? null : (int?)dbCommand.Parameters[ReturnValueParameterName].Value;
            }
        }

    }
}
