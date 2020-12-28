using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp01.Models.Services
{
    public interface IDapperRepository
    {
        //T execute_sp(string query, DynamicParameters sp_params, CommandType commandType = CommandType.StoredProcedure);
        //List<T> GetAll(string query, DynamicParameters sp_params, CommandType commandType = CommandType.StoredProcedure);
    }
}
