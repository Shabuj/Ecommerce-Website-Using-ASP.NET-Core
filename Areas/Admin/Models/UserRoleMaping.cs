using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Areas.Admin.Models
{
    public class UserRoleMaping
    {
        public string UserId { get; set; }       
        public string RoleId { get; set; }
        public string UserName { get; set; }       
        public string RoleName { get; set; }
    }
}
