using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2OnAdoNetWinForms.DbFactory
{
    public class SqlFactory : IDbFactory
    {
        public IDbDataAdapter CreateAdapter(IDbCommand _command)
        {
            return new SqlDataAdapter(_command as SqlCommand);
        }

        public IDbCommand CreateCommand(string _query, IDbConnection _connection)
        {
            return new SqlCommand(_query, _connection as SqlConnection);
        }

        public IDbConnection CreateConnection(string _config)
        {
            return new SqlConnection(_config);
        }

        public IDbDataParameter CreateParameter(string _parameterName, DbType _dbType)
        {
            return new SqlParameter(_parameterName, _dbType);
        }
        public IDbDataParameter CreateParameter(string _parameterName, SqlDbType _dbType)
        {
            return new SqlParameter(_parameterName, _dbType);
        }

        public IDataReader CreateReader(IDbCommand _command)
        {
            return (_command as SqlCommand).ExecuteReader();
        }

        public DbCommandBuilder CreateBuilder(IDbDataAdapter _adapter)
        {
            return new SqlCommandBuilder(_adapter as SqlDataAdapter);
        }
    }
}
