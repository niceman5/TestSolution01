using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45DataBase
{
    public interface IAuthorsRepository
    {
        IEnumerable<Authors> GetAuthorsAll();
        bool Insert(Authors authors);
        bool Update(Authors authors);
        bool Delete(Authors authors);
    }
}
