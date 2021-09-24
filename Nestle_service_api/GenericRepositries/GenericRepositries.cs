using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Nestle_service_api.GenericRepositries
{
    public abstract class GenericRepository<TModel>
    {
        private IConfiguration _configuration;

        public GenericRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        private SqlConnection SqlConnection()
        {
            return new SqlConnection(_configuration.GetSection("ConnectionStrings:DefaultConnection").Value);
        }
        public IDbConnection CreateConnection()
        {
            var conn = SqlConnection();
            conn.Open();
            return conn;
        }
    }
}
