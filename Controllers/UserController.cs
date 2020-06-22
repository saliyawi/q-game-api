using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using q_game_api.Models;
using q_game_api.Repository;
using q_game_api.Filters;

namespace q_game_api.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : Controller
    {
        private IUser userRepo;

        public UserController(IUser userRepo)
        {
            this.userRepo = userRepo;
        }

        /// <summary>
        /// Add User
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddUser")]
        public async Task<int> AddUser([FromBody] User user)
        {
            if (user == null)
                throw new ApiValidationExceptionFilter("User Data is null");

            var userModel = new User();
            userModel.Name = user.Name;
            userModel.Email = user.Email;

            return await this.userRepo.AddUser(userModel);
        }
    }
}
