using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PTTK_SQA.Models.DAO
{
    public class BaseDAO<T> : IDisposable
    {
        protected string _tableName;
        protected string _connectionString;
        protected IDbConnection _dbConnection;

        public BaseDAO()
        {
            _tableName = typeof(T).Name;
            _connectionString = "" +
            "Host = localhost;" +
            "Port = 3306;" +
            "Database =  b17dccn190_dmha_pttk_sqa;" +
            "User Id = root;" +
            "Character Set=utf8";
            _dbConnection = new MySqlConnection(_connectionString);
        }

        public void Dispose()
        {
            if(_dbConnection.State == ConnectionState.Open)
            {
                _dbConnection.Close();
            }
        }
    }
}
