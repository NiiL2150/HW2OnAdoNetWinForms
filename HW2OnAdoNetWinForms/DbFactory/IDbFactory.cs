using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2OnAdoNetWinForms.DbFactory
{
    public interface IDbFactory
    {
        IDbConnection CreateConnection(string _config);
        IDbCommand CreateCommand(string _query, IDbConnection _connection);
        IDataReader CreateReader(IDbCommand _command);
        IDbDataParameter CreateParameter(string _parameterName, DbType _dbType);
        IDbDataParameter CreateParameter(string _parameterName, SqlDbType _dbType);
        IDbDataAdapter CreateAdapter(IDbCommand _command);
        DbCommandBuilder CreateBuilder(IDbDataAdapter _adapter);
    }
}
