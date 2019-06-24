using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestingProject.Models;
using TestingProject.Models.Roles;

namespace TestingProject.Controllers
{
    public class RoleController : Controller
    {
        string result = string.Empty;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddRole(Role obj)
        {
            try
            {
                Role rol = new Role();
                rol.Name = obj.Name;
                rol.CreatedBy = "nasir";
                rol.CreatedOn = DateTime.Now;
                rol.UpdatedBy = "nasir";
                rol.UpdatedOn = DateTime.Now;
                rol.IsActive = true;
                new RoleHandler().AddRole(rol);
            }
            catch (Exception ex)
            {
                result = ex.ToString();
                throw;
            }
            return Json(result);
        }


    }
}