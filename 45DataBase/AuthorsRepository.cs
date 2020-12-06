using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace _45DataBase
{
    public class AuthorsRepository : IAuthorsRepository
    {
        public bool Delete(Authors authors)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Authors> GetAuthorsAll()
        {
            using (IDbConnection db= new SqlConnection(AppConnection.ConnectionString) )
            {
                // db.Open();
                return db.Query<Authors>("select top(100) * from pubs.dbo.authors", commandType: CommandType.Text);
            }
        }

        public bool Insert(Authors authors)
        {
            throw new NotImplementedException();
        }

        public bool Update(Authors authors)
        {
            throw new NotImplementedException();
        }
    }
}