using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp01.Models.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly IConfiguration _configuration;
        public UserRepository(IConfiguration configuration) 
        {
            _configuration = configuration;
        }

        public UsersModel Add(UsersModel model)
        {
            throw new NotImplementedException();
        }

        public int Delete(int user_no)
        {
            throw new NotImplementedException();
        }

        public UsersModel Update(UsersModel model)
        {
            throw new NotImplementedException();
        }

        public List<UsersModel> User_List(int user_no, string search_key, int page, int cnt_page)
        {
            string sp_name = "upUSER_LIST";
            using IDbConnection db = new SqlConnection(_configuration.GetConnectionString("default"));

            var p = new DynamicParameters();
            p.Add("@USER_NO", value: user_no, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@SEARCH_KEY", value: search_key, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@PAGE", value: user_no, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CNT_PAGE", value: user_no, dbType: DbType.Int32, direction: ParameterDirection.Input);

            return db.Query<UsersModel>(sp_name, p, commandType: CommandType.StoredProcedure).ToList();
        }

        public UsersModel User_Select(int user_no)
        {
            throw new NotImplementedException();
        }
    }
}
