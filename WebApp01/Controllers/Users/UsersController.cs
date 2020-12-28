using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using WebApp01.Models;
using WebApp01.Models.Services;

namespace WebApp01.Controllers.Users
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _repository;

        public UsersController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<int> Add(UsersModel user)
        {

            var result = 0;

            return result;
        }

        [HttpPost]
        public async Task<int> Update(UsersModel user)
        {
            var result = 0;

            return result;
        }

        [HttpDelete]
        public async Task<int> Delete(int user_id)
        {
            var result = 0;

            return result;
        }

        [HttpGet]
        public async Task<List<UsersModel>> ListUsers(int user_no, string key, int page, int cnt_page)
        {
            var result = new List<UsersModel>();

            return result;
        }

        [HttpGet]        
        public async Task<UsersModel> GetUser(int user_no)
        {
            var result = new UsersModel(); ;

            return result;
        }

        public async Task<string> Test()
        {
            return "hello world";
        }


    }

}
