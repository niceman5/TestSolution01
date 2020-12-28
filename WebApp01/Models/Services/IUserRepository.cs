using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp01.Models.Services
{
    public interface IUserRepository
    {
        UsersModel Add(UsersModel model);
        List<UsersModel> User_List(int user_no, string search_key, int page, int cnt_page);
        UsersModel User_Select(int user_no);
        UsersModel Update(UsersModel model);
        int Delete(int user_no);
    }
}
