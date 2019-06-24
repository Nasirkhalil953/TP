using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingProject.Models;

namespace TestingProject.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user,string password);
        Task<User> Login(string Username, string Password);
        Task<bool> UserExists(string Username);
    }
}
