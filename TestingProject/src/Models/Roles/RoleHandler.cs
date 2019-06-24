using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingProject.Models.Roles
{
    public class RoleHandler
    {
        public void AddRole(Role obj)
        {
            using (Context db=new Context())
            {
                try
                {
                    db.Roles.Add(obj);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    string error = ex.ToString();
                    throw;
                }
            }
        }


    }
}
