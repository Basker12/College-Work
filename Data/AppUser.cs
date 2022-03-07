using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Design;
using System.Linq;

namespace WebApplication.Data
{
    public class AppUser
    {
        public int userId { get; set; }
        
        public string username { get; set; }
        public string password { get; set; }
        public string Roles { get; set; }

        public List<string> RoleList
        {
            get
            {
                return Roles.Split(',').ToList();
            }
        }
    }
}