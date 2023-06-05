using ADA.ShoppingKart.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADA.ShoppingKart.Models.Entities
{
    public class User
    {
        public string Email { get; set; }
        public string PassHash { get; set; }
        public UserRoles Role { get; set; }
    }
}
