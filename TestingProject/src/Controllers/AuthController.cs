using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestingProject.Data;
using TestingProject.Models;

namespace TestingProject.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IAuthRepository _repo;

        public AuthController(IAuthRepository repo)
        {
            _repo = repo;
        }
        [HttpPost("register")]
        public async Task<IActionResult>Register(string username, string password)
        {
            username = username.ToLower();
            if (await _repo.UserExists(username))
                return BadRequest("User is Already taken");
            var userToCreate = new User
            {
                Username = username
            };
            var createUser = await _repo.Register(userToCreate, password);
            return StatusCode(201);
        }
    }
}